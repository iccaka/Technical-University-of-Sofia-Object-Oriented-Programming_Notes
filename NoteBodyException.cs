using System;
using System.Runtime.Serialization;

namespace Notes
{
    [Serializable]
    internal class NoteBodyException : Exception
    {
        public NoteBodyException()
        {
        }

        public NoteBodyException(string message) : base(message)
        {
        }

        public NoteBodyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoteBodyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}