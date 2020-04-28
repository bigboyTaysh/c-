using ClassLibrary;
using System;
using System.Collections.Generic;

namespace lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentManager documentManagement = new DocumentManager();
            Book book = new Book("aaa", "tytul", new DateTime(1450, 5, 1), 2, "Patryk");
            Book book2 = new Book("aab", "tytul2", new DateTime(2020, 5, 1), 2, "Patryk");
            Magazine magazine = new Magazine("aac", "tytul", new DateTime(2020, 5, 1), 100, 1, Magazine.Frequency.weekly);
            Magazine magazine2 = new Magazine("aad", "tytul", new DateTime(2020, 5, 1), 100, 1, Magazine.Frequency.weekly);
            Volume volume = new Volume("aae", "tytul", new DateTime(2020, 5, 1), 100, "autor", 1, 10);
            Volume volume2 = new Volume("aaf", "tytul", new DateTime(2020, 5, 1), 100, "autor", 1, 10);
            try
            {
                documentManagement.Add(book);
                documentManagement.Add(book2);
                documentManagement.Add(magazine);
                documentManagement.Add(magazine2);
                documentManagement.Add(volume);
                documentManagement.Add(volume2);
            }
            catch(NumberOfVolumeException e)
            {
                ExceptionDetails.Details(e);

            }
            catch (VolumeExistsException e)
            {
                ExceptionDetails.Details(e);

            }
            catch (DokumentExistsException e)
            {
                ExceptionDetails.Details(e);

            }
            catch (DateException e)
            {
                ExceptionDetails.Details(e);

            }
            Console.WriteLine();

            bool continueDoWhile = true;
            char key;
            do
            {
                Console.WriteLine("==================================================");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Wybierz opcję:", Console.ForegroundColor);
                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Wyświetl wszystkie dokumenty.\n" +
                    "2. Metoda usuwającą z listy dokument o wskazanym ISBN.\n" +
                    "3. Metoda zwracająca z listy dokument o wskazanym ISBN.\n" +
                    "4. Metoda zwracająca z listy dokumenty o wskazanym typie.\n" +
                    "5. Metoda zwracającą listę czasopism o podanej częstotliwości .\n" +
                    "8. Wyczyść konsolę.\n" +
                    "9. Zakończ program.");


                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Wybór: ", Console.ForegroundColor);
                key = Console.ReadLine()[0];
                string type;

                switch (key)
                {
                    case '1':
                        ShowAll(documentManagement);
                        Console.WriteLine();
                        break;

                    case '2':
                        Console.Write("Podaj typ dokumentu: ");
                        type = Console.ReadLine();
                        Remove(documentManagement, type);
                        Console.WriteLine();
                        break;

                    case '3':
                        Console.Write("Podaj tytul: ");
                        type = Console.ReadLine();
                        ShowISBN(documentManagement, type);
                        Console.WriteLine();
                        break;

                    case '4':
                        Console.Write("Podaj tytul: ");
                        type = Console.ReadLine();
                        ShowDocuments(documentManagement, type);
                        Console.WriteLine();
                        break;

                    case '5':
                        Console.Write("Podaj czestotliwosc: ");
                        type = Console.ReadLine();
                        Magazine.Frequency MyStatus = (Magazine.Frequency)Enum.Parse(typeof(Magazine.Frequency), type, true);
                        GetMagazines(documentManagement,MyStatus);
                        Console.WriteLine();
                        break;

                    case '8':
                        Console.Clear();
                        Console.WriteLine();
                        break;

                    case '9':
                        Console.WriteLine("Koniec programu");
                        continueDoWhile = false;
                        break;

                    default:
                        continueDoWhile = true;
                        break;
                }
            } while (continueDoWhile);

            /*
            foreach (Document item in documentManagement.ListOfDocuments)
            {
                Console.WriteLine(item.GetType().FullName);
            }
            */

            //documentManagement.GetAllDocuments().ForEach(x => Console.WriteLine(x.ToString()+"\n"));
            //documentManagement.GetVolumes("tytul").ForEach(x => Console.WriteLine(x.ToString() + "\n")); 
        }
        public static void ShowAll(DocumentManager documentManagement) 
        {
            foreach (var item in documentManagement.ListOfDocuments)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }

        public static void Remove(DocumentManager documentManagement, string isbn)
        {
            documentManagement.Remove(isbn);
        }

        public static void ShowISBN(DocumentManager documentManagement, string isbn)
        {
            Console.WriteLine(documentManagement.GetDocument(isbn));
        }

        public static void ShowDocuments(DocumentManager documentManagement, string title)
        {
                foreach (var item in documentManagement.GetDocuments(title))
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }

        public static void GetMagazines(DocumentManager documentManagement, Magazine.Frequency frequency)
        {
            foreach (var item in documentManagement.GetMagazines(frequency))
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }

        public static void ShowType(DocumentManager documentManagement, string type)
        {
            List<Document> list = documentManagement.ListOfDocuments.FindAll(x => x.GetType().Name == type);
            foreach (var item in list)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}
