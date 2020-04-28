using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class House
    {
        public int Area { get; set; }
        public int Price { get; set; }

        public House()
        {
        }

        public House(int area, int price)
        {
            Area = area;
            Price = price;
        }
    }
}
