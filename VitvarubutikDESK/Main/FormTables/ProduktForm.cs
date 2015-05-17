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
        Form1 main;

        private List<int> indexes;

        public ProduktForm(Form1 main)
        {
            this.main = main;
            Show();
            InitializeComponent();

            indexes = main.ListAllProducts(listProducts);
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm apf = new AddProductForm(main);
        }

        private void RedigeraButton_Click(object sender, EventArgs e)
        {
            if (listProducts.SelectedIndex == -1)
                return;

            int id = indexes[listProducts.SelectedIndex];
            List<String> data = main.ListValuesProductID(id);

            for (int i = 0; i < data.Count; i++ )
            {
                Console.WriteLine(data[i]);
            }

            AddProductForm apf = new AddProductForm(main, int.Parse(data[0]), data[1], data[2], data[3], data[4], data[5], int.Parse(data[6]), data[7], int.Parse(data[8]));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listProducts.SelectedIndex == -1)
                return;

            int id = indexes[listProducts.SelectedIndex];
            main.SetQuery("DELETE FROM produkt " +
                "WHERE id =" + id + ";");
            main.Establish_DB_Connection();

            ErrorMsgForm msg = new ErrorMsgForm("Produkt bortagen.");
        }

    }
}
