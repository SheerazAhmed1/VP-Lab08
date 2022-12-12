namespace Activity04
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;
        public Form1()
        {
            InitializeComponent();
            form2=new Form2();
            form3=new Form3();
        }

        private void showForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            form2.Show();
        }

        private void hideForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Hide();   
        }

        private void showForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void hideForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3.Hide();
        }
    }
}