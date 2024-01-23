namespace Projekt_LB3
{
    partial class AddWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWindows));
            textBoxNameAdd = new TextBox();
            textBoxAddressAdd = new TextBox();
            textBoxNumberAdd = new TextBox();
            buttonAddConfirm = new Button();
            SuspendLayout();
            // 
            // textBoxNameAdd
            // 
            textBoxNameAdd.Location = new Point(12, 12);
            textBoxNameAdd.Name = "textBoxNameAdd";
            textBoxNameAdd.PlaceholderText = "Name";
            textBoxNameAdd.Size = new Size(396, 23);
            textBoxNameAdd.TabIndex = 0;
            textBoxNameAdd.Tag = "";
            // 
            // textBoxAddressAdd
            // 
            textBoxAddressAdd.Location = new Point(12, 41);
            textBoxAddressAdd.Name = "textBoxAddressAdd";
            textBoxAddressAdd.PlaceholderText = "Adress";
            textBoxAddressAdd.Size = new Size(396, 23);
            textBoxAddressAdd.TabIndex = 1;
            // 
            // textBoxNumberAdd
            // 
            textBoxNumberAdd.Location = new Point(12, 70);
            textBoxNumberAdd.Name = "textBoxNumberAdd";
            textBoxNumberAdd.PlaceholderText = "Number";
            textBoxNumberAdd.Size = new Size(396, 23);
            textBoxNumberAdd.TabIndex = 2;
            // 
            // buttonAddConfirm
            // 
            buttonAddConfirm.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddConfirm.Location = new Point(12, 118);
            buttonAddConfirm.Name = "buttonAddConfirm";
            buttonAddConfirm.Size = new Size(396, 40);
            buttonAddConfirm.TabIndex = 3;
            buttonAddConfirm.Text = "Add";
            buttonAddConfirm.UseVisualStyleBackColor = true;
            buttonAddConfirm.Click += buttonAddConfirm_Click;
            // 
            // AddWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 182);
            Controls.Add(buttonAddConfirm);
            Controls.Add(textBoxNumberAdd);
            Controls.Add(textBoxAddressAdd);
            Controls.Add(textBoxNameAdd);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddWindows";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add contact";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNameAdd;
        private TextBox textBoxAddressAdd;
        private TextBox textBoxNumberAdd;
        private Button buttonAddConfirm;
    }
}