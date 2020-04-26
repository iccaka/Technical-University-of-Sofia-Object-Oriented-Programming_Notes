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
    public partial class Form1 : Form
    {
        List<string> categories;

        public Form1()
        {
            InitializeComponent();

            this.categories = new List<string>();
            this.categories.Add("default");

            UpdateCategoriesOnScreen();
        }

        private void AddCategory(string category)
        {
            this.categories.Add(category);

            UpdateCategoriesOnScreen();
        }

        private void UpdateCategoriesOnScreen()
        {
            this.listBox1.Items.Clear();

            foreach (string category in this.categories)
            {
                this.listBox1.Items.Add(category);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(AddCategory);
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox listboox = new ListBox();
            listboox.Size = new System.Drawing.Size(100, 100);
            listboox.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(listboox);
        }

        private void zAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
