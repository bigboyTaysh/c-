using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.IO;

namespace Laboratorium3.Models
{
    public class Notatnik
    {
        readonly string path;
        public List<Kontakt> Kontakty { get; set; }

        public Notatnik()
        {
            string dataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory") as string; ;
            path = dataDirectory + "\\notatnik.xml";
            Wczytaj();

        }

        public void Zapisz()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Kontakt>));
            using (Stream fileStream = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fileStream, Kontakty);
            }
        }
  

        public void Wczytaj()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Kontakt>));
            try
            {
                using (Stream fileStream = new FileStream(path, FileMode.Open))
                {
                    Kontakty = (List<Kontakt>)serializer.Deserialize(fileStream);
                }

            }
            catch
            {
                Kontakty = new List<Kontakt>();
            }
        }
    }
}