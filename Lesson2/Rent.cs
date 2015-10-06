namespace Lesson2
{
    class Rent
    {
        public Rent(Car CarToRent, System.DateTime DateOfBeginRent, System.DateTime DateOfEndRent)
        {
            _RentedCar = CarToRent;
            _BeginOfRent = DateOfBeginRent;
            _EndOfRent = DateOfEndRent;
        }

        public Car CarToRent { get { return _RentedCar; } }
        public System.DateTime DateOfEndRent { get { return _EndOfRent; } }
        public System.DateTime DateOfBeginRent{ get { return _BeginOfRent; } }

        private Car _RentedCar;
        private System.DateTime _BeginOfRent, _EndOfRent;
    }
}
