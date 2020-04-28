using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab55
{
    public class FourValueClass<T, Y, U, I> : IComparable where T : IComparable
    {
        private T _id;

        public T Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private Y _first;

        public Y First
        {
            get { return _first; }
            set { _first = value; }
        }
        private U _second;

        public U Second
        {
            get { return _second; }
            set { _second = value; }
        }
        private I _third;

        public I Third
        {
            get { return _third; }
            set { _third = value; }
        }

        public FourValueClass()
        {

        }

        public FourValueClass(T id, Y first, U second, I third)
        {
            _id = id;
            _first = first;
            _second = second;
            _third = third;
        }



        public override string ToString()
        {
            return Id + ", " + First + ", " + Second + ", " + Third;
        }

        public override bool Equals(object obj)
        {
            return this.ToString().Equals(obj.ToString());
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public int CompareTo(object obj)
        {
            var sec = obj as FourValueClass<T, Y, U, I>;
            return Id.CompareTo(sec.Id);

        }
    }
}
