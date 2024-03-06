using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class ComparatorId : IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            if (x.IdNumber.Number > y.IdNumber.Number)
                return 1;
            else if (x.IdNumber.Number < y.IdNumber.Number)
                return -1;
            else
                return 0;
        }
    }
}
