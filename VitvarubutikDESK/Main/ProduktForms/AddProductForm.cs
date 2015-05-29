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
using VitvarubutikDESK.Main.ProduktForms;
using VitvarubutikDESK.Main.Utilities;

namespace VitvarubutikDESK.Main.FormTables
{
    public partial class AddProductForm : FixedForm
    {
        ProduktForm parent;
        private bool spara;
        private int id;

        private List<int> TypIndexes, TillverkareIndexes;

        public AddProductForm(ProduktForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            TypIndexes = new List<int>();
            TillverkareIndexes = new List<int>();

            Show();
            LoadImage();
            RefreshLists();
        }

        public void RefreshLists()
        {
            TypIndexes.Clear();
            TillverkareIndexes.Clear();
            listProduktTyp.Items.Clear();
            listTillverkare.Items.Clear();

            MySqlDataReader reader = Form1.RunQuery("SELECT * FROM ProduktTyp");
            while (reader.Read())
            {
                TypIndexes.Add(reader.GetInt32(0));
                listProduktTyp.Items.Add(reader.GetString(1));
            }
            Form1.CloseConnection(reader);

            MySqlDataReader reader2 = Form1.RunQuery("SELECT * FROM Tillverkare");
            while (reader2.Read())
            {
                TillverkareIndexes.Add(reader2.GetInt32(0));
                listTillverkare.Items.Add(reader2.GetString(1));
            }
            Form1.CloseConnection(reader2);
        }

        public AddProductForm(ProduktForm parent, int id, int typ_id, int tillverkare_id, string model, string energi, string beskrivning, int pris, int antal, string image)
        {
            this.parent = parent;
            this.id = id;
            InitializeComponent();
            Show();
            TypIndexes = new List<int>();
            TillverkareIndexes = new List<int>();
            RefreshLists();

            int id1 = 0;
            int id2 = 0;

            for (int i = 0; i < TypIndexes.Count; i++)
            {
                if (TypIndexes[i] == typ_id)
                    id1 = i;
            }

            for (int i = 0; i < TillverkareIndexes.Count; i++)
            {
                if (TillverkareIndexes[i] == tillverkare_id)
                    id2 = i;
            }

            listProduktTyp.SelectedIndex = id1;
            listTillverkare.SelectedIndex = id2;
            ModelTextBox.Text = model;
            EnergiTextBox.Text = energi;
            BeskrivningTextBox.Text = beskrivning;
            PrisTextBox.Text = "" + pris;
            AntalTextBox.Text = "" + antal;
            ImageTextBox.Text = image;

            AddButton.Text = "Spara";
            spara = true;
            LoadImage();
        }

        protected internal void AddButton_Click(object sender, EventArgs e)
        {
            int pris, antal;
            if (!int.TryParse(PrisTextBox.Text, out pris) && !int.TryParse(AntalTextBox.Text, out antal))
                return;
            if (listTillverkare.SelectedIndex < 0 || listProduktTyp.SelectedIndex < 0)
                return;

            if (!spara)
            {
                MySqlDataReader reader = Form1.RunQuery("INSERT INTO Produkt (P_Typ, Tillverkare, Modell, Energiklass, Beskrivning, Pris, Antal, Bild) " +
                    "VALUES (" + TypIndexes[listProduktTyp.SelectedIndex] + ", " + TillverkareIndexes[listTillverkare.SelectedIndex] + ", '" + 
                    ModelTextBox.Text + "', '" + EnergiTextBox.Text + "', '" + BeskrivningTextBox.Text + "', " + PrisTextBox.Text + ", " + AntalTextBox.Text + ", '" +
                    ImageTextBox.Text + "');");
                Form1.CloseConnection(reader);
            }
            else
            {
                MySqlDataReader r = Form1.RunQuery("UPDATE Produkt " +
                    "SET P_Typ=" + TypIndexes[listProduktTyp.SelectedIndex] + ", Tillverkare=" + TillverkareIndexes[listTillverkare.SelectedIndex] +
                    ", Modell='" + ModelTextBox.Text + "', Energiklass='" + EnergiTextBox.Text + "', Beskrivning='" + BeskrivningTextBox.Text + "', " +
                    "Pris=" + PrisTextBox.Text + ", Antal=" + AntalTextBox.Text + ", Bild='" + ImageTextBox.Text + "' " +
                    "WHERE id=" + id + ";");
            }
            parent.RefreshList();
            this.Close();
        }

        // Lämnar bild länk textboxen
        private void ImageTextBox_Leave(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void LoadImage()
        {
            try
            {
                PictureBox.Load(ImageTextBox.Text);
            }
            catch (Exception ex)
            {
                PictureBox.Load("http://www.hospitalsafetyscore.org/media/image/hss-alert-icon.png");
            }
        }

        private void AddProduktButton_Click(object sender, EventArgs e)
        {
            new AddSmall(this, false);
        }

        private void AddTillverkareButton_Click(object sender, EventArgs e)
        {
            new AddSmall(this, true);
        }
    }
}
