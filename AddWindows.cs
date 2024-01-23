using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_LB3
{
    public partial class AddWindows : Form
    {
        public AddWindows()
        {
            InitializeComponent();
        }

        private void buttonAddConfirm_Click(object sender, EventArgs e)
        {
            string controllName = textBoxNameAdd.Text; 
            string controllAddress = textBoxAddressAdd.Text;
            string controllNumber = textBoxNumberAdd.Text;

            //Checking using the strings above if the user has just wrote whitespace or nothing at all
            if (String.IsNullOrWhiteSpace(controllName) & String.IsNullOrWhiteSpace(controllAddress) & String.IsNullOrWhiteSpace(controllNumber))
            {
                //Error message
                MessageBox.Show("No value has been entered", "Notification");
                textBoxAddressAdd.Text = "";
                textBoxNameAdd.Text = "";
                textBoxNumberAdd.Text = "";
                this.Close();
            }
            else
            {
                //Calling up an instance of form1 and saving data, then using addNewContact(); to safe the data in the string arrays
                Form1 form = new Form1();
                form.nameGetter = textBoxNameAdd.Text;
                form.adressGetter = textBoxAddressAdd.Text;
                form.numberGetter = textBoxNumberAdd.Text;
                form.addNewContact();
                MessageBox.Show("Successfully added new contact", "Notification");
                textBoxAddressAdd.Text = "";
                textBoxNameAdd.Text = "";
                textBoxNumberAdd.Text = "";
                this.Close();
            }
        }
    }
}
