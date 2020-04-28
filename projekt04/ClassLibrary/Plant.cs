using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Plant : Creature, IGrowing, IPlants
    {
        public int AmountOfOxygenProduced { get; set; }

        public enum State { Growing, Bloomed, BoreFruit }

        public State StateOfPlant { get; set; }

        public Plant()
        {
        }

        public Plant(int amountOfOxygenProduced, State stateOfPlant, string name, float height) : base(name, height)
        {
            AmountOfOxygenProduced = amountOfOxygenProduced;
            StateOfPlant = stateOfPlant;
        }

        void IGrowing.Grow()
        {
            Height += AmountOfOxygenProduced/100;
            Console.WriteLine("Rosnę!");
        }

        void IPlants.Grow()
        {
            Height += AmountOfOxygenProduced / 100;
            Console.WriteLine("Rosnę jako roślina!");
        }

        public void Bloom()
        {
            Console.WriteLine("Zakwitnij");
        }

        public void Fruit()
        {
            Console.WriteLine("Owocuje");
        }
    }
}
