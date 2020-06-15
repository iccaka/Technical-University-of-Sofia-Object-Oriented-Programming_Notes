using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notes
{
    public partial class NoteCreationForm : Form
    {

        private StartingForm incomingForm;
        private SortedDictionary<string, ICategory> categoriesToShow;

        public NoteCreationForm(StartingForm incomingForm, SortedDictionary<string, ICategory> categoriesToShow)
        {
            InitializeComponent();
            this.Text = "Create note";

            this.incomingForm = incomingForm;
            this.categoriesToShow = categoriesToShow;

            updateCategoriesOnScreen();
        }

        private void updateCategoriesOnScreen()
        {
            foreach(KeyValuePair<string, ICategory> category in this.categoriesToShow)
            {
                this.comboBox1.Items.Add(category.Key);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string heading = this.textBox1.Text;
            string body = this.richTextBox1.Text;
            string category = this.comboBox1.Text;

            if (category.Equals(""))
            {
                category = "default";
            }

            try
            {
                CustomNote cn = new CustomNote(heading, body);
                this.incomingForm.AddNote(category, cn);

                this.Close();
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Invalid note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
