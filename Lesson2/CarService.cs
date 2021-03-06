﻿using System;
using System.Collections.Generic;

namespace Lesson2
{
    class CarService
    {
        FileDatabase db { get; }
        Rent[] PreventiveDB = new Rent[0];
        Car[] cars = new Car[]
            {
                new Car("БМВ", "Классная машина"),
                new Car("Ауди", "Отличная машина"),
                new Car("Фольксваген", "Прекрасная машина"),
                new Car("Лада", "Машина"),
                new Car("Жигуль", "Ведро с гайками")
            };

        public CarService()
        {
            db = new FileDatabase("C:\\CarRent");
            PreventiveDB = db.GetFromDatabase<Rent>();
        }

        public Car[] GetAviableCars( DateTime DateOfBegin, DateTime DateOfEnd)
        {
            SortedSet<Car> SetOfNotAviableCars = GetNotAviableCars(DateOfBegin, DateOfEnd);

            int NumberOfAviableCar = cars.GetLength(0) - SetOfNotAviableCars.Count;

            Car[] AviableCars = new Car[NumberOfAviableCar];

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
            Rent[] OldArrOfRents = PreventiveDB;
            Rent[] NewArrOfRents = new Rent[OldArrOfRents.GetLength(0) + 1];
            int i;
            for (i = 0; i < OldArrOfRents.GetLength(0); ++i) 
                NewArrOfRents[i] = OldArrOfRents[i];
            NewArrOfRents[i] = OrderParams;
            PreventiveDB = NewArrOfRents;
            db.SaveToDatabase<Rent>(NewArrOfRents);
        }
         
        private SortedSet<Car> GetNotAviableCars(System.DateTime DateOfBegin, System.DateTime DateOfEnd)
        {
            SortedSet<Car> SetOfNotAviableCars = new SortedSet<Car>(new CarComparer());
            int NumberOfNotAviableCars = 0;
            foreach (Rent iRent in PreventiveDB)
                if ( (iRent.DateOfEndRent >= DateOfBegin && iRent.DateOfBeginRent <= DateOfBegin)
                    || (iRent.DateOfEndRent >= DateOfEnd && iRent.DateOfBeginRent <= DateOfEnd)
                        || ( DateOfBegin <= iRent.DateOfBeginRent && DateOfEnd >= iRent.DateOfEndRent ) )
                {
                    SetOfNotAviableCars.Add(iRent.CarToRent);
                    NumberOfNotAviableCars++;
                }

            return (SetOfNotAviableCars);
        }

    }
}
