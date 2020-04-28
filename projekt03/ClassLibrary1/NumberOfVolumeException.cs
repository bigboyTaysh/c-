using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    [Serializable]
    public class NumberOfVolumeException : ApplicationException
    {
        public NumberOfVolumeException() { }
        public NumberOfVolumeException(string message) : base(message) { }
        public NumberOfVolumeException(string message, Exception inner) : base(message, inner) { }
        protected NumberOfVolumeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
