using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Creature
    {
        public String Name { get; set; }
        public float Height { get; set; }

        public Creature()
        {
        }

        public Creature(string name, float height)
        {
            Name = name;
            Height = height;
        }
    }
}
