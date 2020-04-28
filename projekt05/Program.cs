using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab55
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionLab<int> lab = new CollectionLab<int>();
            lab.Enqueue(1);
            lab.Enqueue(2);
            lab.Enqueue(3);
            lab.Enqueue(4);
            foreach (var item in lab.GetList())
            {
                Console.WriteLine(item);
            }

            lab.Dequeue();
            foreach (var item in lab.GetList())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(lab.StackPeek());
            int f = 1;
            int s = 2;
            StaticClass.Swap(ref f, ref s);
            var nowy = StaticClass.GetNewObject<int>();
            Console.WriteLine(f + " " + s + " " + nowy);

            List<FourValueClass<int, int, int, int>> list = new List<FourValueClass<int, int, int, int>>();
            list.Add(new FourValueClass<int, int, int, int>(1, 2, 3, 4));
            list.Add(new FourValueClass<int, int, int, int>(5, 2, 3, 4));
            list.Add(new FourValueClass<int, int, int, int>(6, 2, 3, 4));
            list.Add(new FourValueClass<int, int, int, int>(1, 2, 3, 4));
            list.Add(new FourValueClass<int, int, int, int>(7, 2, 3, 4));
            list.Sort();

            foreach (var fourValueClass in list)
            {
                Console.WriteLine(fourValueClass.Id);
            }

            f= 1;
            s= 2;
            StaticClass.Swap(ref f, ref s);
            Console.WriteLine(f + " " + s);
            StaticClass.GetStatesAndReset(ref f, ref s);
            Console.WriteLine(f + " " + s);
            Console.Read();

        }
    }
}
