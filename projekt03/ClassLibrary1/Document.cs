using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Document
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int NumberOfPages { get; set; }

        public Document()
        {
        }

        public Document(string iSBN, string title, DateTime releaseDate, int numberOfPages)
        {
            ISBN = iSBN;
            Title = title;
            ReleaseDate = releaseDate;
            NumberOfPages = numberOfPages;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}\nTytuł: {Title}\nData wydania: {ReleaseDate}\nLiczba stron: {NumberOfPages}";
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
