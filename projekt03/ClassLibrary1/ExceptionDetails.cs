using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class ExceptionDetails
    {
        public static void Details(ApplicationException e)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            if (e is ApplicationException)
            {
                Console.WriteLine("Wyjątek aplikacyjny");
            }
            else 
            {
                Console.WriteLine("Wyjątek systemowy");
            }

            Console.WriteLine(e.Message);
            Console.WriteLine(e.TargetSite);
            Console.WriteLine(e.StackTrace);
            Console.WriteLine(e.HelpLink);
            if (e.Data.Count > 0)
            {
                Console.WriteLine("Extra details:");
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("    Key: {0,-20}      Value: {1}",
                                      "'" + de.Key.ToString() + "'", de.Value);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
