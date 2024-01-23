namespace Projekt_LB3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            closeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            buttonAdd = new Button();
            buttonSearch = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(2, 1, 0, 1);
            menuStrip1.Size = new Size(586, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(48, 22);
            closeToolStripMenuItem.Text = "&Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(29, 54);
            buttonAdd.Margin = new Padding(1);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(522, 74);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add contact";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Location = new Point(29, 150);
            buttonSearch.Margin = new Padding(1);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(522, 74);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search contact";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(586, 246);
            Controls.Add(buttonSearch);
            Controls.Add(buttonAdd);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button buttonAdd;
        private Button buttonSearch;
    }
}