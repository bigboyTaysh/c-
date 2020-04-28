using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    [Serializable]
    public class DokumentExistsException : ApplicationException
    {
        public DokumentExistsException() { }
        public DokumentExistsException(string message) : base(message) { }
        public DokumentExistsException(string message, Exception inner) : base(message, inner) { }
        protected DokumentExistsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
