using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Bear : Animal, ICarnivorous, IHerbivores
    {
        public Bear()
        {
        }

        public Bear(int speed, string name, float height) : base(speed, name, height)
        {
        }

        public void FindFood()
        {
            Console.WriteLine($"{this.GetType().Name} szuka jedzonka");
        }

        public void EatMeat()
        {
            Console.WriteLine($"{this.GetType().Name} je mięsko");
        }

        public void EatPlant()
        {
            Console.WriteLine($"{this.GetType().Name} je roślinkę");
        }
    }
}
