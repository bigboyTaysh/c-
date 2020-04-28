using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab55
{
    public static class StaticClass
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            var temp = first;
            first = second;
            second = temp;
        }

        public static void GetStatesAndReset<T, H>(ref T first, ref H second)
        {
            Console.WriteLine(first.GetType());
            Console.WriteLine(second.GetType());
            first = default(T);
            second = default(H);
        }

        public static T GetNewObject<T>() where T : new()
        {
            return new T();
        }

        public static T GetGreaterObject<T>(T first, T second) where T : IComparable
        {
            var d = first.CompareTo(second);
            if (d.Equals(1))
            {
                return first;
            }
            else
            {
                return second;
            }

        }

        public static List<T> SortParams<T>(params T[] args)
        {
            List<T> list = new List<T>();
            foreach (T arg in args)
            {
                list.Add(arg);
            }
            list.Sort();
            return list;
        }

        public static IDictionary<T, H> GetDictionary<T, H>(T key, H value) where T : struct where H : class
        {
            IDictionary<T, H> dictionary = new Dictionary<T, H>();
            dictionary.Add(new KeyValuePair<T, H>(key, value));
            return dictionary;
        }

        public static void GetDictionaryValues<T, H>(IDictionary<T, H> dictionary)
        {
            foreach (var h in dictionary)
            {
                Console.WriteLine(h.Key + ", " + h.Value);
            }
        }

        public static System.Collections.ICollection GetStackOrQueue<T>(params T[] args)
        {
            if (args.Length < 3)
            {
                Queue<T> queue = new Queue<T>();
                foreach (var arg in args)
                {
                    queue.Enqueue(arg);
                }

                return queue;
            }
            else
            {
                Stack<T> stack = new Stack<T>();
                foreach (var arg in args)
                {
                    stack.Push(arg);
                }

                return stack;
            }
        }
    }
}
