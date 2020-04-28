using System.Collections.Generic;

namespace Notes
{
    abstract class BaseCategory : ICategory
    {
        protected string name;
        protected List<INote> notesList;

        public BaseCategory(string name)
        {
            this.SetName(name);
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            if (name.Length == 0 || name.Length > 16)
            {
                throw new CategoryNameException("The names of the categories must be 1-16 characters long.");
            }
            else
            {
                this.name = name;
            }
        }

        public List<INote> GetNotesList()
        {
            return this.notesList;
        }
    }
}
