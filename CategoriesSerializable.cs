using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{

    [Serializable]
    public class CategoriesSerializable
    {
        private SortedDictionary<string, ICategory> categories;

        public CategoriesSerializable(SortedDictionary<string, ICategory> categories)
        {
            this.Categories = categories;
        }

        public virtual SortedDictionary<string, ICategory> Categories
        {
            get
            {
                return this.categories;
            }
            set
            {
                this.categories = value;
            }
        }
    }
}
