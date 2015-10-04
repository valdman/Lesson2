namespace Lesson2
{
    class Rent
    {
        public Rent(Car CarToRent, System.DateTime WhishableDateOfBegin, System.DateTime WhishableDateOfEnd)
        {
            _RentedCar = CarToRent;
            _BeginOfRent = WhishableDateOfBegin;
            _EndOfRent = WhishableDateOfEnd;
        }

        public Car GetRentedCar() { return _RentedCar; }
        public System.DateTime GetDateOfBeginRent() { return _BeginOfRent; }
        public System.DateTime GetDateOfEndRent() { return _EndOfRent; }

        private Car _RentedCar;
        private System.DateTime _BeginOfRent, _EndOfRent;
    }
}
