using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class HumanNumberOfHousesComparer: IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Human h1 = (Human)x; 
            Human h2 = (Human)y;

            return h1.Cars.Count.CompareTo(h2.Cars.Count);
        }
    }
}
