using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Cat : Animal, ICarnivorous
    {
        public string Race { get; set; }

        public Cat()
        {
        }

        public Cat(string race, int speed, string name, float height) : base(speed, name, height)
        {
            Race = race;
        }

        public void FindFood()
        {
            Console.WriteLine($"{this.GetType().Name} szuka jedzonka");
        }

        public void EatMeat()
        {
            Console.WriteLine($"{this.GetType().Name} je mięsko");
        }
    }
}
