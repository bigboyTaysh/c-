using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    [Serializable]
    public class VolumeExistsException : ApplicationException
    {
        public VolumeExistsException() { }
        public VolumeExistsException(string message) : base(message) { }
        public VolumeExistsException(string message, Exception inner) : base(message, inner) { }
        protected VolumeExistsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
