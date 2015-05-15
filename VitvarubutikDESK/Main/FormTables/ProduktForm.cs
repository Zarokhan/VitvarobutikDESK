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

        public ProduktForm(Form1 main)
        {
            this.main = main;
            Show();
            InitializeComponent();
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm apf = new AddProductForm(main);
        }
    }
}
