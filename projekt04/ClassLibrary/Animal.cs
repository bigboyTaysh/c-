using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Animal : Creature, IGrowing, ICloneable
    {
        private int _speed;
        public int Speed 
        {
            get 
            {
                return _speed;
            }
            set
            {
                if (value < 1225 || value > 0)
                {
                    _speed = value;
                }
                else
                {
                    throw new SpeedException("Nieprawidłowa prędkość!");
                }
            }
        }

        public Animal()
        {
        }

        public Animal(int speed, string name, float height) : base(name, height)
        {
            Speed = speed;
        }

        public void Grow()
        {
            Height = (Height * 1.10f);
            Console.WriteLine("Rosnę");
        }

        virtual public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
