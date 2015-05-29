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
    public partial class LeverantörForm : FixedForm
    {
        List<int> indexes;

        public LeverantörForm()
        {
            InitializeComponent();
            indexes = new List<int>();
            RefreshList();
            this.Show();
        }

        public void RefreshList()
        {
            indexes.Clear();
            ListBox.Items.Clear();

            MySqlDataReader reader = Form1.RunQuery("SELECT * FROM Leverantör");

            while (reader.Read())
            {
                indexes.Add(reader.GetInt32(0));
                ListBox.Items.Add("Namn: " + reader.GetString(1) + " Address: " + reader.GetString(3) + " Telefon: " + reader.GetString(2));
            }

            Form1.CloseConnection(reader);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex < 0)
                return;

            new SpecifiedLeverantörForm(this);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex < 0)
                return;

            MySqlDataReader reader = Form1.RunQuery("SELECT * FROM Leverantör WHERE id=" + indexes[ListBox.SelectedIndex]);
            reader.Read();
            new SpecifiedLeverantörForm(this, reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
            Form1.CloseConnection(reader);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex < 0)
                return;

            MySqlDataReader reader = Form1.RunQuery("DELETE FROM Leverantör WHERE id=" + indexes[ListBox.SelectedIndex]);
            Form1.CloseConnection(reader);
            this.RefreshList();
        }
    }
}
