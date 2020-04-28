using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassLibrary
{
    public class DocumentManager
    {
        public List<Document> ListOfDocuments = new List<Document>();

        public void Add(Document document)
        {
            if (ListOfDocuments.Any(x => x.ISBN == document.ISBN))
            {
                throw new DokumentExistsException("W liście istnieje już taki dokument!");
            }
            else if (document.GetType().Name == "Volume")
            {
                Volume volumeFromArgument = (Volume)document;
                foreach (var item in ListOfDocuments)
                {
                    if (item.GetType().Name == "Volume") 
                    {
                        Console.WriteLine("dsada");
                        Volume volume = (Volume)item;
                        if (volume.NumberOfVolume == volumeFromArgument.NumberOfVolume && item.Title.Equals(document.Title))
                        {
                            throw new VolumeExistsException("W liście istnieje już taki tom!");
                        }
                    }
                }
                if (volumeFromArgument.NumberOfVolume > volumeFromArgument.NumberOfAllVolumes)
                {
                    throw new NumberOfVolumeException("Numer tomu nie może być większy od liczby tomów danej serii!");
                }

                ListOfDocuments.Add(document);
            }
            else if (document.GetType().Name == "Book")
            {
                Book book = (Book) document;
                if (DateTime.Compare(book.ReleaseDate, new DateTime(1450, 1, 1)) < 1)
                {
                    throw new DateException("Nieprawidłowa data!");
                }

                ListOfDocuments.Add(document);
            }
            else
            {
                ListOfDocuments.Add(document);
            }

        }

        public void Remove(string isbn)
        {
            ListOfDocuments.RemoveAll(x => x.ISBN == isbn);
        }

        public Document GetDocument(string isbn)
        {
            return ListOfDocuments.Find(x => x.ISBN == isbn);
        }

        public List<Document> GetDocuments(string title)
        {
            return ListOfDocuments.FindAll(x => x.Title.Contains(title));
        }

        public List<Document> GetAllDocuments()
        {
            return ListOfDocuments;
        }
        public List<Magazine> GetMagazines(Magazine.Frequency frequency) 
        {
            return ListOfDocuments.FindAll(x => x is Magazine && ((Magazine)x).FrequencyVar == frequency)
                .Cast<Magazine>().ToList();
        }

        public List<Volume> GetVolumes(string title)
        {
            return ListOfDocuments.FindAll(x => x.GetType().Name == "Volume" && x.Title.Contains(title))
                .Cast<Volume>().ToList();
        }

    }
}
