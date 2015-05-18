using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitvarubutikDESK.Main.Utilities;

namespace VitvarubutikDESK.Main.FormTables
{
    public partial class AddKundForm : FixedForm
    {
        Form1 main;
        private bool spara;
        private int kundnr;

        public AddKundForm(Form1 main)
        {
            this.main = main;
            InitializeComponent();
            Show();
        }

        public AddKundForm(Form1 main, int kundnr, string telnr, string address, string mail, string namn)
        {
            this.main = main;
            this.kundnr = kundnr;
            InitializeComponent();
            Show();

            NamnTextBox.Text = namn;
            NummerTextBox.Text = telnr;
            EmailTextBox.Text = mail;
            AddressTextBox.Text = address;

            AddButton.Text = "Spara";
            spara = true;
        }

        protected internal void AddButton_Click(object sender, EventArgs e)
        {
            if (NamnTextBox.Text == "")
                return;

            if (!spara)
            {
                this.main.SetQuery(
                    "INSERT INTO kund (TelNr, Address, Mail, Namn) " + 
                    "VALUES ('" + NummerTextBox.Text + "', '" + AddressTextBox.Text + "', '" + EmailTextBox.Text + "', '" + NamnTextBox.Text + "' );");
            
                main.Establish_DB_Connection();
            }
            else
            {
                this.main.SetQuery(
                    "UPDATE kund " + 
                    "SET TelNr='" + NummerTextBox.Text + "', Address='" + AddressTextBox.Text + "', Mail='" + EmailTextBox.Text + "', Namn='" + NamnTextBox.Text + "' " +
                    "WHERE KundNr=" + kundnr + ";");
                main.Establish_DB_Connection();
            }
            this.Close();
        }

    }
}
