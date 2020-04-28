using System.Collections.Generic;

namespace Notes
{
    public interface ICategory
    {
        string GetName();
        void SetName(string name);
        Dictionary<string, INote> GetNotesList();
        INote GetNote(string heading);
        void AddNote(INote note);
        void RemoveNote(string heading);
    }
}
