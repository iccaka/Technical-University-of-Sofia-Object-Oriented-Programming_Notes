using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{

    [Serializable]
    public class CategoriesSerializable : BaseCategoriesSerializable
    {
        public CategoriesSerializable(IDictionary<string, ICategory> categories) : base(categories) { }


        public new virtual IDictionary<string, ICategory> Categories
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
