using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    [Serializable]
    public class DateException : ApplicationException
    {
        public DateException() { }
        public DateException(string message) : base(message) { }
        public DateException(string message, Exception inner) : base(message, inner) { }
        protected DateException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
