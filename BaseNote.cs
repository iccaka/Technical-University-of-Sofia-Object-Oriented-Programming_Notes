using System.Runtime.Remoting.Messaging;

namespace Notes
{
    abstract class BaseNote : INote
    {

        protected string heading;
        protected string body;
        
        public BaseNote(string heading, string body)
        {
            this.Heading = heading;
            this.Body = body;
        }
        public virtual string Heading
        {
            get
            {
                return this.heading;
            }
            set
            {
                if (value.Length == 0 || value.Length > 64)
                {
                    throw new NoteHeadingException("The heading of the notes must be 1-64 characters long.");
                }
                else
                {
                    this.heading = value;
                }
            }
        }
        public virtual string Body
        {
            get
            {
                return this.body;
            }
            set
            {
                if (value.Length == 0 || value.Length > 4096)
                {
                    throw new NoteBodyException("The body of the notes must be 1-4096 characters long.");
                }
                else
                {
                    this.body = value;
                }
            }
        }
    }
}
