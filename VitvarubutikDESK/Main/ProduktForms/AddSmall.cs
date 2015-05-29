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
using VitvarubutikDESK.Main.FormTables;
using VitvarubutikDESK.Main.Utilities;

namespace VitvarubutikDESK.Main.ProduktForms
{
    public partial class AddSmall : FixedForm
    {
        AddProductForm parent;

        bool Tillverkare;
        string RefreshQuery;
        string TableName;
        string ColumnName;
        List<int> indexes;

        public AddSmall(AddProductForm parent, bool Tillverkare)
        {
            this.parent = parent;
            this.Tillverkare = Tillverkare;
            InitializeComponent();
            this.Show();
            indexes = new List<int>();

            if (Tillverkare)
            {
                RefreshQuery = "SELECT * FROM Tillverkare";
                TableName = ColumnName = "Tillverkare";
            }
            else
            {
                RefreshQuery = "SELECT * FROM ProduktTyp";
                TableName = "ProduktTyp";
                ColumnName = "Typ";
            }

            RefreshList();
        }

        private void RefreshList()
        {
            indexes.Clear();
            ListBox.Items.Clear();

            MySqlDataReader reader = Form1.RunQuery(RefreshQuery);
            while (reader.Read())
            {
                indexes.Add(reader.GetInt32(0));
                ListBox.Items.Add(reader.GetString(1));
            }
            Form1.CloseConnection(reader);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = Form1.RunQuery("INSERT INTO " + TableName + " (" + ColumnName + ") VALUES ('" + TextBox.Text + "');");
            Form1.CloseConnection(reader);
            RefreshList();
            parent.RefreshLists();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int id = indexes[ListBox.SelectedIndex];
            MySqlDataReader reader = Form1.RunQuery("DELETE FROM " + TableName + " WHERE id=" + id + ";");
            Form1.CloseConnection(reader);
            RefreshList();
            parent.RefreshLists();
        }
    }
}
