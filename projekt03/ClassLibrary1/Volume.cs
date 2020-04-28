using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Volume : Book
    {

        public int NumberOfVolume { get; set; }
        public int NumberOfAllVolumes { get; set; }

        public Volume()
        {

        }

        public Volume(string iSBN, string title, DateTime releaseDate, int numberOfPages, string author, int numberOfVolue, int numberOfAllVolumes)
            : base (iSBN, title, releaseDate, numberOfPages, author)
        {
            NumberOfVolume = numberOfVolue;
            NumberOfAllVolumes = numberOfAllVolumes;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nTom: {NumberOfVolume}\nLiczba wszystkich tomów: {NumberOfAllVolumes}";
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
