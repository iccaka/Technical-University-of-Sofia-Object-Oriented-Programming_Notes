using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public class DecreaseComparer : IComparer<string>
    {
        public int Compare(string x, string y) { return -x.CompareTo(y); }
    }
}
