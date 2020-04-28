using System.Collections.Generic;

namespace Notes
{
    public interface ICategory
    {   
        string Name
        {
            get;
            set;
        }
        Dictionary<string, INote> NotesList
        {
            get;
        }
        INote GetNote(string heading);
        void AddNote(INote note);
        void RemoveNote(string heading);
    }
}
