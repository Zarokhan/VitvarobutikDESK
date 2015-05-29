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

namespace VitvarubutikDESK.Main.KampanjForms
{
    public partial class AddKampanjForm : FixedForm
    {
        private KampanjForm parent;
        private List<int> indexes;

        public AddKampanjForm(KampanjForm parent)
        {
            this.parent = parent;
            indexes = new List<int>();
            InitializeComponent();
            RefreshList();
            this.Show();
        }

        private void RefreshList()
        {
            indexes.Clear();
            ListBox.Items.Clear();

            MySqlDataReader reader = Form1.RunQuery("SELECT * FROM ProduktTyp");
            while (reader.Read())
            {
                indexes.Add(reader.GetInt32(0));
                ListBox.Items.Add(reader.GetString(1));
            }
            Form1.CloseConnection(reader);
        }

        private void ReaBar_ValueChanged(object sender, EventArgs e)
        {
            ReaLabel.Text = ReaBar.Value + "%";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex < 0)
            {
                new MsgForm("Välj produkttyp");
                return;
            }

            float t;
            if (!float.TryParse("" + ReaBar.Value/100f, out t))
            {
                new MsgForm("REA FAIL");
                return;
            }

            float rea = 1 - ReaBar.Value / 100f;
            string r = "" + rea;
            string dafs = r.Replace(",", ".");
            Console.WriteLine(dafs);

            MySqlDataReader reader = Form1.RunQuery("INSERT INTO Kampanj (ProduktTyp, REA, Beskrivning, StartDatum, SlutDatum) " +
                "VALUES (" + indexes[ListBox.SelectedIndex] + ", " + dafs + ", '" + BeskrivningText.Text + "' ," + StartDate.Value.ToString("yyyyMMdd") + ", " + EndDate.Value.ToString("yyyyMMdd") + ");");
            Form1.CloseConnection(reader);

            parent.RefreshList();
            this.Close();
        }

    }
}
