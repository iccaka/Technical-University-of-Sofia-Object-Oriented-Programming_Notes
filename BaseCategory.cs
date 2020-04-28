using System.Collections.Generic;

namespace Notes
{
    abstract class BaseCategory : ICategory
    {
        protected string name;
        protected Dictionary<string, INote> notesList;

        public BaseCategory(string name)
        {
            this.notesList = new Dictionary<string, INote>();
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
        public Dictionary<string, INote> GetNotesList()
        {
            return this.notesList;
        }
        public INote GetNote(string heading)
        {
            return this.notesList[heading];
        }
        public void AddNote(INote note)
        {
            this.notesList.Add(note.GetHeading(), note);
        }
        public void RemoveNote(string heading)
        {
            this.notesList.Remove(heading);
        }
    }
}
