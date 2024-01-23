using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_LB3
{
    public partial class SearchWindows : Form
    {
        string nameSearch;
        string addresSearch;
        string numberSearch;
        string[] searchResults = new string[9999];
        public SearchWindows()
        {
            InitializeComponent();
        }

        private void buttonSearchConfirm_Click(object sender, EventArgs e)
        {
            Array.Clear(searchResults, 0, searchResults.Length);
            nameSearch = textBoxNameSearch.Text.Trim();
            addresSearch = textBoxAddressSearch.Text.Trim();
            numberSearch = textBoxNumberSearch.Text.Trim();
            Form1 form = new Form1();
            for (int i = 0; i < form.name.Length; i++) 
            {
                
                if (form.name[i].Contains(nameSearch))
                {
                    searchResults[i] = $"{form.name[i]} {form.address[i]} {form.number[i]}";
                }
                if (form.address[i].Contains(addresSearch))
                {
                    searchResults[i] = $"{form.name[i]} {form.address[i]} {form.number[i]}";
                }
                if (form.number[i].Contains(numberSearch))
                {
                    searchResults[i] = $"{form.name[i]} {form.address[i]} {form.number[i]}";
                }
            }
            string resultsMessage = string.Join(Environment.NewLine, searchResults.Where(result => result != null));
            MessageBox.Show(resultsMessage, "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
