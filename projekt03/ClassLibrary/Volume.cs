using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Volume : Book
    {

        public int NumberOfVolue { get; set; }
        public int NumberOfAllVolumes { get; set; }

        public Volume()
        {

        }

        public Volume(string iSBN, string tytul, DateTime releaseDate, int numberOfPages, string author, int numberOfVolue, int numberOfAllVolumes)
            : base (iSBN, tytul, releaseDate, numberOfPages, author)
        {
            NumberOfVolue = numberOfVolue;
            NumberOfAllVolumes = numberOfAllVolumes;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nTom: {NumberOfVolue}\nLiczba wszystkich tomów: {NumberOfAllVolumes}";
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
