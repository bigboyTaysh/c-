using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Ghost : Creature
    {
        private int _transparency;
        public int Transparency {
            get { return _transparency; }
            set 
            {
                if (value > 0 || value < 100)
                {
                    _transparency = value;
                }
                else 
                {
                    throw new TransparencyException("Nieprawidłowa wartość!");
                }
                    
            } 
        }
        public int AmountOfEktoplasm { get; set; }

        public Ghost()
        {
        }

        public Ghost(int transparency, int amountOfEktoplasm, string name, float height) : base(name, height)
        {
            Transparency = transparency;
            AmountOfEktoplasm = amountOfEktoplasm;
        }

        public void Scare()
        {
            Console.WriteLine("Boo");
        }
    }
}
