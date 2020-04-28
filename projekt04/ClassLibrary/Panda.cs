using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Panda : Animal, IHerbivores
    {
        public Panda()
        {
        }

        public Panda(int speed, string name, float height) : base(speed, name, height)
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
