﻿using MySql.Data.MySqlClient;
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

namespace VitvarubutikDESK.Main.KundForms
{
    public partial class KundForm : FixedForm
    {
        private List<int> kundnr;

        public KundForm()
        {
            InitializeComponent();
            kundnr = new List<int>();
            RefreshList();
            this.Show();
        }

        public void RefreshList()
        {
            kundnr.Clear();
            ListBox.Items.Clear();

            MySqlDataReader reader = Form1.RunQuery("SELECT * FROM Kund");
            while (reader.Read())
            {
                kundnr.Add(reader.GetInt32(0));
                ListBox.Items.Add("Namn: " + reader.GetString(1) + " Tel: " + reader.GetString(2) + " Address: " + reader.GetString(3) + " Mail: " + reader.GetString(4));
            }
            Form1.CloseConnection(reader);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new SpecifiedKundForm(this);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex < 0)
                return;

            MySqlDataReader reader = Form1.RunQuery("SELECT * FROM Kund WHERE Kundnr=" + kundnr[ListBox.SelectedIndex]);
            reader.Read();
            new SpecifiedKundForm(this, reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
            Form1.CloseConnection(reader);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex < 0)
                return;

            MySqlDataReader reader = Form1.RunQuery("DELETE FROM Kund WHERE Kundnr=" + kundnr[ListBox.SelectedIndex]);
            Form1.CloseConnection(reader);

            RefreshList();
        }
    }
}
