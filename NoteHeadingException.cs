using System;
using System.Runtime.Serialization;

namespace Notes
{
    [Serializable]
    internal class NoteHeadingException : Exception
    {
        public NoteHeadingException()
        {
        }

        public NoteHeadingException(string message) : base(message)
        {
        }

        public NoteHeadingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoteHeadingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}