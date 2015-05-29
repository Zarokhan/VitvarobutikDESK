using MySql.Data.MySqlClient;
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

namespace VitvarubutikDESK.Main.KundForms
{
    public partial class SpecifiedKundForm : FixedForm
    {
        KundForm parent;
        bool edit;

        public SpecifiedKundForm(KundForm parent)
        {
            this.parent = parent;
            this.edit = false;
            InitializeComponent();

            KundnrLabel.Text = "";

            this.Show();
        }

        public SpecifiedKundForm(KundForm parent, int kundnr, string namn, string telnr, string address, string mail)
        {
            this.parent = parent;
            this.edit = true;
            InitializeComponent();

            KundnrLabel.Text = "" + kundnr;
            NamnBox.Text = namn;
            TelnrBox.Text = telnr;
            AddressBox.Text = address;
            MailBox.Text = mail;
            AddButton.Text = "Spara";

            this.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                MySqlDataReader reader = Form1.RunQuery("INSERT INTO Kund (Namn, Telnr, Address, Mail) " +
                    "VALUES ('" + NamnBox.Text + "', '" + TelnrBox.Text + "', '" + AddressBox.Text + "', '" + MailBox.Text + "');");
                Form1.CloseConnection(reader);
            }
            else
            {
                MySqlDataReader reader = Form1.RunQuery("UPDATE Kund " +
                    "SET Namn='" + NamnBox.Text + "', Telnr='" + TelnrBox.Text + "', Address='" + AddressBox.Text + "', Mail='" + MailBox.Text + "' " +
                    "WHERE Kundnr=" + KundnrLabel.Text + ";");
                Form1.CloseConnection(reader);
            }

            parent.RefreshList();
            this.Close();
        }
    }
}
