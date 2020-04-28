using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{

    [Serializable]
    public class SpeedException : ApplicationException
    {
        public SpeedException() { }
        public SpeedException(string message) : base(message) { }
        public SpeedException(string message, Exception inner) : base(message, inner) { }
        protected SpeedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
