using System;
using System.Collections.Generic;

namespace Lesson2
{
    class CarService
    {
        FileDatabase db;
        public CarService()
        {
            db = new FileDatabase("C:\\CarRent");
        }

        public Car[] GetAviableCars(Car[] cars, DateTime DateOfBegin, DateTime DateOfEnd)
        {
            SortedSet<Car> SetOfNotAviableCars = new SortedSet<Car>();

            int NumberOfNotAviableCars = 0;
            foreach (Rent iRent in db.GetFromDatabase<Rent>())
                if (iRent.GetDateOfEndRent() > DateOfBegin || iRent.GetDateOfBeginRent() < DateOfEnd) {
                    SetOfNotAviableCars.Add(iRent.GetRentedCar());
                    NumberOfNotAviableCars++;
                }


            int NumberOfAviableCars = cars.GetLength(0) - NumberOfNotAviableCars;
            Car[] AviableCars = new Car[NumberOfAviableCars];

            int i = 0;
            foreach (Car CheckedCar in cars)
                if (!(SetOfNotAviableCars.Contains(CheckedCar)))
                {
                    AviableCars[i] = CheckedCar;
                    i++;
                }
            return (AviableCars);  
        }

        public void DoAnOrder(Rent OrderParams)
        {
            Rent[] OldArrOfRents = db.GetFromDatabase<Rent>();
            Rent[] NewArrOfRents = new Rent[OldArrOfRents.GetLength(0) + 1];
            int i;
            for (i = 0; i < OldArrOfRents.GetLength(0); ++i) 
                NewArrOfRents[i] = OldArrOfRents[i];
            NewArrOfRents[i] = OrderParams;
            db.SaveToDatabase<Rent>(NewArrOfRents);
        }
            
    }
}
