using System;

namespace Notes
{
    [Serializable]
    internal class CustomNote : BaseNote
    {
        public CustomNote(string heading, string body) : base(heading, body){}
    }
}