using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab55
{
    public class CollectionLab<T>
    {
        private IList<T> list;

        public CollectionLab()
        {
            list = new List<T>();
        }

        public void Enqueue(T elo)
        {
            list.Insert(list.Count, elo);
        }

        public T QueuePeek()
        {
            return list[0];
        }

        public T Dequeue()
        {
            var item = list[0];
            list.RemoveAt(0);
            return item;
        }
        public void Push(T elo)
        {
            list.Insert(list.Count, elo);
        }

        public T StackPeek()
        {
            return list[list.Count - 1];
        }

        public T Pop()
        {
            var item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }
        public IList<T> GetList()
        {
            return list;
        }

    }
}
