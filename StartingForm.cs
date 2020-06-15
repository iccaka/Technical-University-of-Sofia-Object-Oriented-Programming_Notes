using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Notes
{
    public partial class StartingForm : Form
    {
        private SortedDictionary<string, ICategory> categories;
        private string selectedCategory;
        public static readonly string DEFAULT_SERIALIZABLE_FILE = "StartingFormCategoriesData.bin";

        public StartingForm()
        {
            InitializeComponent();
            this.Text = "Notes";

            this.categories = new SortedDictionary<string, ICategory>();

            this.Deserialize();
            this.UpdateCategoriesOnScreen();
        }
        private void AddDefaultCategory()
        {
            CustomCategory defaultCategory = new CustomCategory("default");
            this.AddCategory(defaultCategory);
        }
        public void AddCategory(ICategory category)
        {
            this.categories.Add(category.Name, category);

            this.Serialize();
            this.UpdateCategoriesOnScreen();
        }
        public void AddNote(string category, INote note)
        {
            this.categories[category].AddNote(note);
            this.Serialize();
        }
        private void UpdateCategoriesOnScreen()
        {
            this.listBox1.Items.Clear();

            foreach(KeyValuePair<string, ICategory> category in this.categories)
            {
                this.listBox1.Items.Add(category.Key);
            }
        }
        private void UpdateNotesOnScreen()
        {
            this.listBox2.Items.Clear();

            ICategory cc = this.categories[this.selectedCategory];
            Dictionary<string, INote> categoryList = cc.NotesList;

            foreach (KeyValuePair<string, INote> note in categoryList)
            {
                this.listBox2.Items.Add(note.Value.Heading);
            }
        }
        private void ClearNoteBodyOnScreen()
        {
            this.textBox1.Clear();
            this.richTextBox1.Clear();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoryCreationForm ccForm = new CategoryCreationForm(this);
            ccForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(this.listBox1.SelectedIndex == -1)
            {
                return;
            }

            this.ClearNoteBodyOnScreen();

            string categoryToDelete = this.listBox1.SelectedItem.ToString();

            this.categories.Remove(categoryToDelete);

            if (this.categories.Count == 0)
            {
                this.AddDefaultCategory();
            }

            this.Serialize();
            this.UpdateCategoriesOnScreen();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedIndex == -1)
            {
                return;
            }

            string selectedNote = this.listBox2.SelectedItem.ToString();
            INote note = this.categories[this.selectedCategory].GetNote(selectedNote);

            this.textBox1.Clear();
            this.richTextBox1.Clear();
            this.textBox1.Text = note.Heading;
            this.richTextBox1.Text = note.Body;
        }
        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortedDictionary<string, ICategory> sortedCategories = new SortedDictionary<string, ICategory>(new IncreaseComparer());

            foreach(KeyValuePair<string, ICategory> category in this.categories)
            {
                sortedCategories.Add(category.Key, category.Value);
            }

            this.categories = sortedCategories;

            this.Serialize();
            this.UpdateCategoriesOnScreen();
        }
        private void zAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortedDictionary<string, ICategory> sortedCategories = new SortedDictionary<string, ICategory>(new DecreaseComparer());

            foreach (KeyValuePair<string, ICategory> category in this.categories)
            {
                sortedCategories.Add(category.Key, category.Value);
            }

            this.categories = sortedCategories;

            this.Serialize();
            this.UpdateCategoriesOnScreen();
        }
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteCreationForm ncForm = new NoteCreationForm(this, this.categories);
            ncForm.Show();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearNoteBodyOnScreen();

            if (this.listBox1.SelectedIndex == -1)
            {
                return;
            }

            this.selectedCategory = this.listBox1.SelectedItem.ToString();

            this.UpdateNotesOnScreen();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedIndex == -1)
            {
                return;
            }

            string noteToDelete = this.listBox2.SelectedItem.ToString();
            this.categories[this.selectedCategory].RemoveNote(noteToDelete);

            this.Serialize();
            this.ClearNoteBodyOnScreen();
            this.UpdateNotesOnScreen();
        }

        private void Serialize()
        {
            Stream stream = new FileStream(DEFAULT_SERIALIZABLE_FILE, FileMode.Create, FileAccess.Write, FileShare.None);

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            CategoriesSerializable categoriesSerializable = new CategoriesSerializable(this.categories);

            binaryFormatter.Serialize(stream, categoriesSerializable);

            stream.Close();
        }

        private void Deserialize()
        {     
            Stream stream = new FileStream(DEFAULT_SERIALIZABLE_FILE, FileMode.Open, FileAccess.Read, FileShare.Read);

            if(stream.Length == 0)
            {
                stream.Close();
                this.AddDefaultCategory();
                return;
            }

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            CategoriesSerializable categoriesSerializable = (CategoriesSerializable)binaryFormatter.Deserialize(stream);
            this.categories = categoriesSerializable.Categories;

            stream.Close();
        }
    }
}
