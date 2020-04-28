using System;
using System.Windows.Forms;

namespace Notes
{
    public partial class CategoryCreationForm : Form
    {

        private StartingForm incomingForm;

        public CategoryCreationForm(StartingForm incomingForm)
        {
            InitializeComponent();

            this.incomingForm = incomingForm;
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
            string categoryName = this.textBox1.Text;

            try
            {
                CustomCategory cc = new CustomCategory(categoryName);
                this.incomingForm.AddCategory(cc);

                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Invalid category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
