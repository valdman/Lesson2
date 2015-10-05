using System.Collections.Generic;

namespace Lesson2
{
    class CarComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
