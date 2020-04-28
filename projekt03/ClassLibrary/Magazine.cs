using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Magazine : Document
    {
        public int Number { get; set; }
        public enum Frequency { diary, weekly, monthly, yearbook };

        public Magazine()
        {
        }

        public Magazine(string iSBN, string tytul, DateTime releaseDate, int numberOfPages) : base(iSBN, tytul, releaseDate, numberOfPages)
        {
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
