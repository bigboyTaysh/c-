using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{

    [Serializable]
    public class TransparencyException : ApplicationException
    {
        public TransparencyException() { }
        public TransparencyException(string message) : base(message) { }
        public TransparencyException(string message, Exception inner) : base(message, inner) { }
        protected TransparencyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
