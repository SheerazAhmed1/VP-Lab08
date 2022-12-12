namespace Activity04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideForm3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showForm3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.form3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideForm2ToolStripMenuItem,
            this.showForm2ToolStripMenuItem});
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.form2ToolStripMenuItem.Text = "Form2";
            // 
            // form3ToolStripMenuItem
            // 
            this.form3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideForm3ToolStripMenuItem,
            this.showForm3ToolStripMenuItem});
            this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
            this.form3ToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.form3ToolStripMenuItem.Text = "Form3";
            // 
            // hideForm2ToolStripMenuItem
            // 
            this.hideForm2ToolStripMenuItem.Name = "hideForm2ToolStripMenuItem";
            this.hideForm2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hideForm2ToolStripMenuItem.Text = "Hide Form2";
            this.hideForm2ToolStripMenuItem.Click += new System.EventHandler(this.hideForm2ToolStripMenuItem_Click);
            // 
            // showForm2ToolStripMenuItem
            // 
            this.showForm2ToolStripMenuItem.Name = "showForm2ToolStripMenuItem";
            this.showForm2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.showForm2ToolStripMenuItem.Text = "Show Form2";
            this.showForm2ToolStripMenuItem.Click += new System.EventHandler(this.showForm2ToolStripMenuItem_Click);
            // 
            // hideForm3ToolStripMenuItem
            // 
            this.hideForm3ToolStripMenuItem.Name = "hideForm3ToolStripMenuItem";
            this.hideForm3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hideForm3ToolStripMenuItem.Text = "Hide Form3";
            this.hideForm3ToolStripMenuItem.Click += new System.EventHandler(this.hideForm3ToolStripMenuItem_Click);
            // 
            // showForm3ToolStripMenuItem
            // 
            this.showForm3ToolStripMenuItem.Name = "showForm3ToolStripMenuItem";
            this.showForm3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.showForm3ToolStripMenuItem.Text = "Show Form3";
            this.showForm3ToolStripMenuItem.Click += new System.EventHandler(this.showForm3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem form2ToolStripMenuItem;
        private ToolStripMenuItem hideForm2ToolStripMenuItem;
        private ToolStripMenuItem showForm2ToolStripMenuItem;
        private ToolStripMenuItem form3ToolStripMenuItem;
        private ToolStripMenuItem hideForm3ToolStripMenuItem;
        private ToolStripMenuItem showForm3ToolStripMenuItem;
    }
}