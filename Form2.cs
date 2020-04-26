using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class Form2 : Form
    {

        Action<string> AddCategory = null;

        public Form2(Action<string> AddCategory)
        {
            InitializeComponent();

            this.AddCategory = AddCategory;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createCategory(object sender, EventArgs e)
        {
            string category = this.textBox1.Text;

            if(this.AddCategory != null)
            {
                AddCategory(category);
                this.Close();
            }
        }
    }
}
