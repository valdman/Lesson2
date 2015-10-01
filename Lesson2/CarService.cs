namespace Lesson2
{
    class CarService
    {
        FileDatabase db = new FileDatabase("%USERPROFILE%/Documents/CarRent");

        public Car[] GetAviableCars(Car[] cars)
        {
            int NumberOfCars = cars.GetLength(0);
            Car[] AviableCars = new Car[0];
            foreach(Car iCar in cars)
                if( db.GetFromDatabase(iCar) )
        }
    }
}
