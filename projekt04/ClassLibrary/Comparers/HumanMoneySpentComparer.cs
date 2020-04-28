using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    class HumanMoneySpentComparer: IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Human h1 = (Human)x;
            Human h2 = (Human)y;

            var sum1 = h1.Cars.Sum(x => x.Price) + h1.Houses.Sum(x => x.Price);
            var sum2 = h2.Cars.Sum(x => x.Price) + h2.Houses.Sum(x => x.Price);

            return sum1.CompareTo(sum2);
        }
    }
}
