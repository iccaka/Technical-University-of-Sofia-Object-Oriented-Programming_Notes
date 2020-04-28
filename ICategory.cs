using System.Collections.Generic;

namespace Notes
{
    public interface ICategory
    {
        string GetName();
        void SetName(string name);
        List<INote> GetNotesList();
    }
}
