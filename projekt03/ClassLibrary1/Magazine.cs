using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Magazine : Document
    {
        public int Number { get; set; }
        public Frequency FrequencyVar { get; set; }
        public enum Frequency { diary, weekly, monthly, yearbook };

        public Magazine()
        {
        }

        public Magazine(string iSBN, string title, DateTime releaseDate, int numberOfPages, int number, Frequency frequency) 
            : base(iSBN, title, releaseDate, numberOfPages)
        {
            Number = number;
            FrequencyVar = frequency;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nNumer magazynu: {Number}";
        }

        public override bool Equals(object obj)
        {
            return ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
