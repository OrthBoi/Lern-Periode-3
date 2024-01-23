using System.Diagnostics.Metrics;
using System.Media;
using System.Windows.Forms;

namespace Projekt_LB3
{
    public partial class Form1 : Form
    {
        private SoundPlayer radioplayerMenu;
        public string[] name = new string[9999];
        public string[] address = new string[9999];
        public string[] number = new string[9999];
        
        int counter = 0;
        public string nameGetter { get; set; }
        public string adressGetter { get; set; }
        public string numberGetter { get; set; }

        

        public void addNewContact() //Function to safe data from "AddWindows" to the string Arrays
        {
            name[counter] = nameGetter;
            address[counter] = adressGetter;
            number[counter] = numberGetter;
            counter++;
        } //WORKS


        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 9999;  i++)
            {
                name[i] = " ";
            }
            for (int i = 0; i < 9999; i++)
            {
                address[i] = " ";
            }
            for (int i = 0; i < 9999; i++)
            {
                number[i] = " ";
            }
            radioplayerMenu = new SoundPlayer(); //If i've got enough time i'll add an radio player
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) //closes app
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //About page
        {
            MessageBox.Show("BBB Project made by Orthboi", "About");
        }



        private void buttonAdd_Click(object sender, EventArgs e) //Add a new contact
        {
            AddWindows addAContact = new AddWindows();
            addAContact.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e) //Search up a contact
        {
            SearchWindows searchAContact = new SearchWindows();
            searchAContact.Show();
        }

        
    }
}