using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notes
{
    public partial class StartingForm : Form
    {
        Dictionary<string, ICategory> categories;

        public StartingForm()
        {
            InitializeComponent();

            this.categories = new Dictionary<string, ICategory>();

            CustomCategory defaultCategory = new CustomCategory("default");
            this.AddCategory(defaultCategory);

            UpdateCategoriesOnScreen();
        }

        public void AddCategory(ICategory category)
        {
            this.categories.Add(category.GetName(), category);

            UpdateCategoriesOnScreen();
        }

        private void UpdateCategoriesOnScreen()
        {
            this.listBox1.Items.Clear();

            foreach(KeyValuePair<string, ICategory> category in this.categories)
            {
                this.listBox1.Items.Add(category.Key);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoryCreationForm ccForm = new CategoryCreationForm(this);
            ccForm.Show();
        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void zAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
