namespace Notes
{
    abstract class BaseNote : INote
    {

        protected string heading;
        protected string body;
        
        public BaseNote(string heading, string body)
        {
            this.SetHeading(heading);
            this.SetBody(body);
        }

        public string GetHeading()
        {
            return this.heading;
        }

        public void SetHeading(string heading)
        {
            if (heading.Length == 0 || heading.Length > 64)
            {
                throw new HeadingException("The headings of the notes must be 1-64 characters long.");
            }
            else
            {
                this.heading = heading;
            }
        }

        public string GetBody()
        {
            return this.body;
        }

        public void SetBody(string body)
        {
            if (body.Length == 0 || body.Length > 4096)
            {
                throw new NoteBodyException("The body of the notes must be 1-4096 characters long.");
            }
            else
            {
                this.body = body;
            }
        }
    }
}
