namespace Projekt_LB3
{
    partial class SearchWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchWindows));
            textBoxNameSearch = new TextBox();
            textBoxAddressSearch = new TextBox();
            textBoxNumberSearch = new TextBox();
            buttonSearchConfirm = new Button();
            SuspendLayout();
            // 
            // textBoxNameSearch
            // 
            textBoxNameSearch.Location = new Point(29, 33);
            textBoxNameSearch.Margin = new Padding(7, 8, 7, 8);
            textBoxNameSearch.Name = "textBoxNameSearch";
            textBoxNameSearch.PlaceholderText = "Name";
            textBoxNameSearch.Size = new Size(956, 47);
            textBoxNameSearch.TabIndex = 1;
            textBoxNameSearch.Tag = "";
            // 
            // textBoxAddressSearch
            // 
            textBoxAddressSearch.Location = new Point(29, 112);
            textBoxAddressSearch.Margin = new Padding(7, 8, 7, 8);
            textBoxAddressSearch.Name = "textBoxAddressSearch";
            textBoxAddressSearch.PlaceholderText = "Adress";
            textBoxAddressSearch.Size = new Size(956, 47);
            textBoxAddressSearch.TabIndex = 2;
            // 
            // textBoxNumberSearch
            // 
            textBoxNumberSearch.Location = new Point(29, 191);
            textBoxNumberSearch.Margin = new Padding(7, 8, 7, 8);
            textBoxNumberSearch.Name = "textBoxNumberSearch";
            textBoxNumberSearch.PlaceholderText = "Number";
            textBoxNumberSearch.Size = new Size(956, 47);
            textBoxNumberSearch.TabIndex = 3;
            // 
            // buttonSearchConfirm
            // 
            buttonSearchConfirm.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchConfirm.Location = new Point(29, 323);
            buttonSearchConfirm.Margin = new Padding(7, 8, 7, 8);
            buttonSearchConfirm.Name = "buttonSearchConfirm";
            buttonSearchConfirm.Size = new Size(962, 109);
            buttonSearchConfirm.TabIndex = 4;
            buttonSearchConfirm.Text = "Search";
            buttonSearchConfirm.UseVisualStyleBackColor = true;
            buttonSearchConfirm.Click += buttonSearchConfirm_Click;
            // 
            // SearchWindows
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 497);
            Controls.Add(buttonSearchConfirm);
            Controls.Add(textBoxNumberSearch);
            Controls.Add(textBoxAddressSearch);
            Controls.Add(textBoxNameSearch);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 8, 7, 8);
            Name = "SearchWindows";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search contact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNameSearch;
        private TextBox textBoxAddressSearch;
        private TextBox textBoxNumberSearch;
        private Button buttonSearchConfirm;
    }
}