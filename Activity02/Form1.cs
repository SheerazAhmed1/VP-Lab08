using System.Security.Cryptography.X509Certificates;

namespace Activity02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btnNotepad=new Button();
            Button btnPaint=new Button();
            Button btpwrpoint=new Button();

            btnNotepad.Text = "Notepad";
            btnPaint.Text = "Ms Paint";
            btpwrpoint.Text = "Ms Power Point";

            btnNotepad.Size = new System.Drawing.Size(250,100);
            btnPaint.Size = new System.Drawing.Size(250, 100);
            btpwrpoint.Size = new System.Drawing.Size(250, 100);

            btnNotepad.Location = new Point(250, 50);
            btnPaint.Location = new Point(250, 150);
            btpwrpoint.Location = new Point(250, 250);

            btnNotepad.Click += new EventHandler(btnNotepad_Click);
            btnPaint.Click += new EventHandler(btnPaint_Click);
            btpwrpoint.Click += new EventHandler(btpwrpoint_Click);

             void btnNotepad_Click(object sender,EventArgs e)
            {

                System.Diagnostics.Process.Start("notepad.exe");

            }

            void btnPaint_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("mspaint.exe");

            }

            void btpwrpoint_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("MSPOWERPNT.EXE");
            }


            Controls.Add(btnNotepad);
            Controls.Add(btnPaint);
            Controls.Add(btpwrpoint);

        }
    }
}