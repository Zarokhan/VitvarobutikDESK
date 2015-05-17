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
    public partial class AddProductForm : FixedForm
    {
        Form1 main;
        private bool spara;
        private int id;

        public AddProductForm(Form1 main)
        {
            this.main = main;
            InitializeComponent();
            Show();
        }

        public AddProductForm(Form1 main, int id, string typ, string tillverkare, string model, string energi, string beskrivning, int pris, string image, int antal)
        {
            this.main = main;
            this.id = id;
            InitializeComponent();
            Show();

            TypeTextBox.Text = typ;
            TillverkareTextBox.Text = tillverkare;
            ModelTextBox.Text = model;
            EnergiTextBox.Text = energi;
            BeskrivningTextBox.Text = beskrivning;
            PrisTextBox.Text = "" + pris;
            ImageTextBox.Text = image;
            AntalTextBox.Text = "" + antal;

            AddButton.Text = "Spara";
            spara = true;
        }

        protected internal void AddButton_Click(object sender, EventArgs e)
        {
            int pris, antal;
            if (!int.TryParse(PrisTextBox.Text, out pris) && !int.TryParse(AntalTextBox.Text, out antal))
                return;

            if (!spara)
            {
                this.main.SetQuery(
                    "INSERT INTO produkt (produkt_typ, tillverkare, model, energiklass, beskrivning, pris, image, antal) " + 
                    "VALUES ('" + this.TypeTextBox.Text + "', '" + this.TillverkareTextBox.Text + "', '" + this.ModelTextBox.Text + "', " +
                    "'" + EnergiTextBox.Text + "', '" + BeskrivningTextBox.Text + "', " + pris + ", '" + this.ImageTextBox.Text + "', " + AntalTextBox.Text + ");");
            
                main.Establish_DB_Connection();
            }
            else
            {
                this.main.SetQuery(
                    "UPDATE produkt " +
                    "SET produkt_typ='" + TypeTextBox.Text + "', tillverkare='" + TillverkareTextBox.Text + "', model='" + ModelTextBox.Text + "', energiklass='" +
                    EnergiTextBox.Text + "', beskrivning='" + BeskrivningTextBox.Text + "', pris=" + PrisTextBox.Text + ", image='" + ImageTextBox.Text + "', " + 
                    "antal=" + AntalTextBox.Text + " " +
                    "WHERE id=" + id + ";");

                main.Establish_DB_Connection();
            }
            this.Close();
        }

    }
}
