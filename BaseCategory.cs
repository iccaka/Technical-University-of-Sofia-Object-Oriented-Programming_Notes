using System;
using System.Collections.Generic;

namespace Notes
{

    [Serializable]
    abstract class BaseCategory : ICategory
    {
        protected string name;
        protected Dictionary<string, INote> notesList;

        public BaseCategory(string name)
        {
            this.notesList = new Dictionary<string, INote>();
            this.Name = name;
        }
        public virtual string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length == 0 || value.Length > 16)
                {
                    throw new CategoryNameException("The names of the categories must be 1-16 characters long.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public virtual Dictionary<string, INote> NotesList
        {
            get
            {
                return this.notesList;
            }
        }
        public virtual INote GetNote(string heading)
        {
            return this.notesList[heading];
        }
        public virtual void AddNote(INote note)
        {
            this.notesList.Add(note.Heading, note);
        }
        public virtual void RemoveNote(string heading)
        {
            this.notesList.Remove(heading);
        }
    }
}
