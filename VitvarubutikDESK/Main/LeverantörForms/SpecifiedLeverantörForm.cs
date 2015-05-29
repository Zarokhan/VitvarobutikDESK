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

namespace VitvarubutikDESK.Main.LeverantörForms
{
    public partial class SpecifiedLeverantörForm : FixedForm
    {
        LeverantörForm parent;
        bool edit;
        int id;

        public SpecifiedLeverantörForm(LeverantörForm parent)
        {
            this.parent = parent;
            InitializeComponent();

            this.Show();
        }

        public SpecifiedLeverantörForm(LeverantörForm parent, int id, string namn, string telnr, string address)
        {
            this.parent = parent;
            InitializeComponent();
            this.edit = true;
            AddButton.Text = "Spara";
            this.id = id;

            NamnBox.Text = namn;
            TelnrBox.Text = telnr;
            AddressBox.Text = address;

            this.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                MySqlDataReader reader = Form1.RunQuery("INSERT INTO Leverantör (Namn, Address, Telnr) " +
                    "VALUES ('" + NamnBox.Text + "', '" + AddressBox.Text + "', '" + TelnrBox.Text + "')");
                Form1.CloseConnection(reader);
            }
            else
            {
                MySqlDataReader reader = Form1.RunQuery("UPDATE Leverantör " +
                    "SET Namn='" + NamnBox.Text + "', Telnr='" + TelnrBox.Text + "', Address='" + AddressBox.Text + "' " +
                    "WHERE id=" + id + ";");
                Form1.CloseConnection(reader);
            }

            parent.RefreshList();
            this.Close();
        }
    }
}
