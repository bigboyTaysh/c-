using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Koala : Animal, IHerbivores
    {
        public Koala()
        {
        }

        public Koala(int speed, string name, float height) : base(speed, name, height)
        {
        }

        public void FindFood()
        {
            Console.WriteLine($"{this.GetType().Name} szuka jedzonka");
        }

        public void EatPlant()
        {
            Console.WriteLine($"{this.GetType().Name} je roślinkę");
        }
    }
}
