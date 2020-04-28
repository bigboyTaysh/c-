using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {
        public String Model { get; set; }
        public int Price { get; set; }

        public Car()
        {
        }

        public Car(string model, int price)
        {
            Model = model;
            Price = price;
        }
    }
}
