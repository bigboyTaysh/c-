using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Dog : Animal, ICarnivorous
    {
        public string Race { get; set; }

        public Dog()
        {
        }

        public Dog(string race, int speed, string name, float height) : base(speed, name, height)
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
