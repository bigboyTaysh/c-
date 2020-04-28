using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Book : Document
    {
        public string Author { get; set; }

        public Book()
        {

        }
        //Listę initcializacyjną umieszczamy za sygnaturą konstruktora a przed jego ciałem
        public Book(string iSBN, string title, DateTime releaseDate, int numberOfPages, string author) 
            : base(iSBN, title, releaseDate, numberOfPages)
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
