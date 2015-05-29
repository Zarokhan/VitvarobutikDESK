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

namespace VitvarubutikDESK.Main.FormTables
{
    public partial class ProduktForm : FixedForm
    {
        private List<int> indexes;

        public ProduktForm()
        {
            Show();
            InitializeComponent();
            indexes = new List<int>();
            RefreshList();
        }

        public void RefreshList()
        {
            indexes.Clear();
            listProducts.Items.Clear();

            MySqlDataReader reader = Form1.RunQuery("SELECT Produkt.id, ProduktTyp.Typ, Tillverkare.Tillverkare, Produkt.Modell, Produkt.Energiklass, Produkt.Beskrivning, Produkt.Bild, Produkt.Pris, Produkt.Antal " +
                "FROM Produkt "+
                    "JOIN ProduktTyp "+
                        "ON Produkt.P_Typ=ProduktTyp.id "+
                    "JOIN Tillverkare "+
                        "ON Produkt.Tillverkare=Tillverkare.id");

            while (reader.Read())
            {
                indexes.Add(reader.GetInt32(0));
                listProducts.Items.Add(reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4) + " Pris: " + reader.GetString(7) + " kr Antal: " + reader.GetString(8));
            }

            Form1.CloseConnection(reader);
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            new AddProductForm(this);
        }

        private void RedigeraButton_Click(object sender, EventArgs e)
        {
            if (listProducts.SelectedIndex == -1)
                return;

            int id = indexes[listProducts.SelectedIndex];
            List<string> data = new List<string>();

            MySqlDataReader reader = Form1.RunQuery("SELECT * FROM Produkt WHERE id=" + id);
            reader.Read();
            for (int i = 0; i < 9; i++)
            {
                data.Add(reader.GetString(i));
            }
            Form1.CloseConnection(reader);

            new AddProductForm(this, int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]), data[3], data[4], data[5], int.Parse(data[6]), int.Parse(data[7]), data[8]);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listProducts.SelectedIndex == -1)
                return;

            MySqlDataReader reader = Form1.RunQuery("DELETE FROM Produkt WHERE id=" + indexes[listProducts.SelectedIndex]);
            Form1.CloseConnection(reader);

            MsgForm msg = new MsgForm("Produkt borttagen.");
            RefreshList();
        }

    }
}
