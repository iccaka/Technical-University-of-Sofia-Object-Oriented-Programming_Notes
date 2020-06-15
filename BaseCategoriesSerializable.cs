using System;
using System.Collections.Generic;

namespace Notes
{

    [Serializable]
    public class BaseCategoriesSerializable : ICategoriesSerializable
    {
        protected IDictionary<string, ICategory> categories;

        public BaseCategoriesSerializable(IDictionary<string, ICategory> categories)
        {
            this.Categories = categories;
        }

        public virtual IDictionary<string, ICategory> Categories {
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
