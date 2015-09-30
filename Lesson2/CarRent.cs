using System.Windows.Forms;

namespace Lesson2
{
	public partial class CarRent : Form
	{
		public CarRent()
		{
			InitializeComponent();
		}

        private void CarList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedCar = CarList.SelectedItem as Car;
            CarDescription.Text = selectedCar.GetDescription();
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

            CarList.Items.AddRange(cars);
        }

        System.DateTime currentDate = new System.DateTime();
        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            var selectedDate1 = dateTimePicker1.Value;
            currentDate = selectedDate1;
        }

        private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
        {
            var selectedData2 = dateTimePicker2.Value;
            if(selectedData2 < currentDate)
            {
                dateTimePicker2.Value = currentDate;
            }

            
        }
    }
}
