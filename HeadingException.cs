using System;
using System.Runtime.Serialization;

namespace Notes
{
    [Serializable]
    internal class HeadingException : Exception
    {
        public HeadingException()
        {
        }

        public HeadingException(string message) : base(message)
        {
        }

        public HeadingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HeadingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}