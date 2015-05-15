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

        public AddProductForm(Form1 main)
        {
            this.main = main;
            InitializeComponent();
            Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int pris;
            if (!int.TryParse(PrisTextBox.Text, out pris))
                return;

            this.main.SetQuery(
                "INSERT INTO produkt (produkt_typ, tillverkare, model, energiklass, beskrivning, pris, image, antal) " + 
                "VALUES ('" + this.TypeTextBox.Text + "', '" + this.TillverkareTextBox.Text + "', '" + this.ModelTextBox.Text + "', " +
                "'" + EnergiTextBox.Text + "', '" + BeskrivningTextBox.Text + "', " + pris + ", '" + this.ImageTextBox.Text + "', " + AntalTextBox.Text + ");");
            
            main.Establish_DB_Connection();
            this.Close();
        }

    }
}
