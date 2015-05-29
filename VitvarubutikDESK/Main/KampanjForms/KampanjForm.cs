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
    public partial class KampanjForm : FixedForm
    {
        private List<int> indexes;

        public KampanjForm()
        {
            indexes = new List<int>();
            InitializeComponent();
            RefreshList();
            this.Show();    
        }

        public void RefreshList()
        {
            indexes.Clear();
            ListBox.Items.Clear();

            MySqlDataReader reader = Form1.RunQuery("SELECT Kampanj.id, ProduktTyp.Typ, Kampanj.REA, DATE_FORMAT(Kampanj.StartDatum, '%Y-%m-%d'), DATE_FORMAT(Kampanj.SlutDatum, '%Y-%m-%d') " +
                "FROM Kampanj " +
                "JOIN ProduktTyp " +
                "ON Kampanj.ProduktTyp=ProduktTyp.id");
            while (reader.Read())
            {
                indexes.Add(reader.GetInt32(0));
                ListBox.Items.Add("REA Produkter: " + reader.GetString(1) + " REA: " + (1 - reader.GetFloat(2)) * 100 + "% Start: " + reader.GetString(3) + " Slut: " + reader.GetString(4));
            }
            Form1.CloseConnection(reader);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddKampanjForm(this);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex < 0)
            {
                new MsgForm("Välj en kampanj!");
                return;
            }

            MySqlDataReader reader = Form1.RunQuery("DELETE FROM Kampanj WHERE id=" + indexes[ListBox.SelectedIndex]);
            Form1.CloseConnection(reader);

            RefreshList();
        }

    }
}
