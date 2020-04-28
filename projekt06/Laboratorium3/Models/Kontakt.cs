using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorium3.Models
{
    public class Kontakt
    {
        public enum Grupa
        {
            Praca,
            Przyjaciele,
            Rodzina,
            Znajomi
        }

        public Grupa grupa { get; set; }

        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}