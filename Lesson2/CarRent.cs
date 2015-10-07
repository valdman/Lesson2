using System.Windows.Forms;

namespace Lesson2
{
	public partial class CarRent : Form
	{

        CarService service;
        public CarRent()
		{
			InitializeComponent();
            service = new CarService();
            _DateOfBegin = dateTimePicker1.Value;
            _DateOfEnd = dateTimePicker2.Value;
        }

        private Car _selectedCar = new Car("","");
        private void CarList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _selectedCar = CarList.SelectedItem as Car;
            CarDescription.Text = _selectedCar.Description;
        }

        private void CarRent_Load(object sender, System.EventArgs e)
        {
            ReloadCarList();
        }

        private System.DateTime _DateOfBegin = new System.DateTime();
        private System.DateTime _DateOfEnd = new System.DateTime();


        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value > dateTimePicker2.Value ? dateTimePicker1.Value : dateTimePicker2.Value;
            _DateOfEnd = dateTimePicker2.Value;
            _DateOfBegin = dateTimePicker1.Value;
            ReloadCarList();
        }

        private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value > dateTimePicker2.Value ? dateTimePicker2.Value : dateTimePicker1.Value;
            _DateOfEnd = dateTimePicker2.Value;
            _DateOfBegin = dateTimePicker1.Value;
            ReloadCarList();

        }

        private void MakeAnOrderButton_Click(object sender, System.EventArgs e)
        {
            Rent OrderParams = new Rent(_selectedCar, _DateOfBegin, _DateOfEnd);
            service.DoAnOrder(OrderParams);
            ReloadCarList();
        }

        private void ReloadCarList()
        {
            CarList.Items.Clear();
            CarList.Items.AddRange(service.GetAviableCars(_DateOfBegin, _DateOfEnd));
            CarList.SelectedItem = CarList.Items[0];
        }

        //private System.DateTime CorrectTime(System.DateTime OrderTime, bool IsEndOfOrder)
        //{
        //    if( OrderTime.Date == System.DateTime.Today && IsEndOfOrder || OrderTime > System.DateTime.Today )
        //    {
        //        System.DateTime RightTime = OrderTime;
        //        RightTime.AddHours(23 - OrderTime.Hour);
        //        RightTime.AddMinutes(59 - OrderTime.Minute);
        //        RightTime.AddSeconds(59 - OrderTime.Second);
        //        return (RightTime);
        //    }
        //    if(OrderTime.Date > System.DateTime.Today && !IsEndOfOrder)

        //}
    }
}