using System.Windows.Forms;

namespace Lesson2
{
	public partial class CarRent : Form
	{
		public CarRent()
		{
			InitializeComponent();
		}

        private Car _selectedCar = new Car("","");
        private void CarList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _selectedCar = CarList.SelectedItem as Car;
            CarDescription.Text = _selectedCar.GetDescription();
        }

        private void CarRent_Load(object sender, System.EventArgs e)
        {
            Car[] cars = new Car[]
            {
                new Car("БМВ", "Классная машина"),
                new Car("Ауди", "Отличная машина"),
                new Car("Фольксваген", "Прекрасная машина"),
                new Car("Лада", "Машина"),
                new Car("Жигуль", "Ведро с гайками")
            };

            CarService Service = new CarService();
            CarList.Items.AddRange(Service.GetAviableCars(cars, _DateOfBegin, _DateOfEnd));
        }

        private System.DateTime _DateOfBegin = new System.DateTime();
        private System.DateTime _DateOfEnd = new System.DateTime();


        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value > dateTimePicker2.Value ? dateTimePicker1.Value : dateTimePicker2.Value;
            _DateOfBegin = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value > dateTimePicker2.Value ? dateTimePicker2.Value : dateTimePicker1.Value;
            _DateOfEnd = dateTimePicker2.Value;

        }

        private void MakeAnOrderButton_Click(object sender, System.EventArgs e)
        {
            Rent OrderParams = new Rent(_selectedCar, _DateOfBegin, _DateOfEnd);
            CarService service = new CarService();
            service.DoAnOrder(OrderParams);
        }
    }
}
