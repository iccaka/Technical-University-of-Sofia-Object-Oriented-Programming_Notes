using System.Collections.Generic;

namespace Notes
{
    internal class Category
    {
        string name;
        List<Note> notesList;

        public Category(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if(value.Length == 0 || value.Length > 16)
                {
                    throw new CategoryNameException("The names of the categories must be 1-16 characters long.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}