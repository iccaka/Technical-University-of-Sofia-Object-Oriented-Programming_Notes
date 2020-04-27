namespace Notes
{
    internal class Note
    {
        string heading;
        string body;
        Category category;

        public Note(string heading, string body, Category category)
        {

        }

        public string Heading{
            get
            {
                return this.heading;
            }

            set
            {
                if (value.Length == 0 || value.Length > 64)
                {
                    throw new HeadingException("The headings of the notes must be 1-64 characters long.");
                }
                else
                {
                    this.heading = value;
                }
            }
        }

        public string Body
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