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
    public partial class KundForm : FixedForm
    {
        Form1 main;
        private List<int> indexes;

        public KundForm(Form1 main)
        {
            this.main = main;
            Show();
            InitializeComponent();

            indexes = main.ListAllKunder(this.listKunder);
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            new AddKundForm(main);
        }

        private void RedigeraButton_Click(object sender, EventArgs e)
        {
            if (listKunder.SelectedIndex == -1)
                return;

            int id = indexes[listKunder.SelectedIndex];
            List<String> data = main.ListValuesKundID(id);

            for (int i = 0; i < data.Count; i++ )
            {
                Console.WriteLine(data[i]);
            }

            new AddKundForm(main, id, data[1], data[2], data[3], data[4]);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listKunder.SelectedIndex == -1)
                return;

            int id = indexes[listKunder.SelectedIndex];
            main.SetQuery("DELETE FROM kund " +
                "WHERE KundNr =" + id + ";");
            main.Establish_DB_Connection();

            MsgForm msg = new MsgForm("Kund bortagen.");
        }

    }
}
