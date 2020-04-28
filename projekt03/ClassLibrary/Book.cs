using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Book : Document
    {
        public string Author { get; set; }

        public Book()
        {

        }

        public Book(string iSBN, string tytul, DateTime releaseDate, int numberOfPages, string author) 
            : base(iSBN, tytul, releaseDate, numberOfPages)
        {
            Author = author;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nAutor: {Author}";
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
