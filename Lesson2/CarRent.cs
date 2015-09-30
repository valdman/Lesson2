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

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value > dateTimePicker2.Value ? dateTimePicker1.Value : dateTimePicker2.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value > dateTimePicker2.Value ? dateTimePicker2.Value : dateTimePicker1.Value;



        }
    }
}
