using System;
using System.Runtime.Serialization;

namespace Notes
{
    [Serializable]
    internal class CategoryNameException : Exception
    {
        public CategoryNameException()
        {
        }

        public CategoryNameException(string message) : base(message)
        {
        }

        public CategoryNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CategoryNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}