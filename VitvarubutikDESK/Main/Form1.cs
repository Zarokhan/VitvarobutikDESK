using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using VitvarubutikDESK.Main;
using VitvarubutikDESK.Main.Utilities;
using System.Threading;
using VitvarubutikDESK.Main.FormTables;
using VitvarubutikDESK.Main.KundForms;
using VitvarubutikDESK.Main.LeverantörForms;

namespace VitvarubutikDESK
{
    public partial class Form1 : FixedForm
    {
        // Database connection properties
        public static string Host { get; set; }
        public static string Database { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static MySqlConnection connection;

        // Error Message
        private MsgForm ErrorForm;

        // Main program
        public Form1()
        {
            InitializeComponent();
            DefaultSettings();
            Update_Label_Texts();

            CheckConnection();
        }

        public void CheckConnection()
        {
            MySqlDataReader reader = RunQuery("Show tables");
            if (reader == null)
            {
                status_label.Text = "Disconnected";
                status_label.ForeColor = Color.Red;
            }
            else
            {
                status_label.Text = "Connected";
                status_label.ForeColor = Color.Green;
            }
            CloseConnection(reader);
            Update_Label_Texts();
        }

        public static MySqlDataReader RunQuery(string query)
        {
            connection = null;
            MySqlDataReader reader = null;

            try
            {
                // Connection
                connection = new MySqlConnection("server=" + Host + ";uid=" + Username + ";pwd=" + Password + ";database=" + Database + ";");
                connection.Open();

                // Query
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Prepare();
                reader = cmd.ExecuteReader();

            } catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            Console.Read();

            return reader;
        }

        public static void CloseConnection(MySqlDataReader reader)
        {
            if (reader != null)
                reader.Close();
            if (connection != null)
                connection.Close();
        }

        // Default database login info
        public void DefaultSettings()
        {
            Host = "195.178.235.60";
            Database = "ae5929";
            Username = "ae5929";
            Password = "Applikationer1";
        }

        // Update db/connection labels
        public void Update_Label_Texts()
        {
            ipaddress_label.Text = Host;
            dbname_label.Text = Database;
            username_label.Text = Username;
            password_label.Text = Password;

        }

        // Open up Connection Settings
        private void ConnectionSettings_MouseClick(object sender, MouseEventArgs e)
        {
            new ConnectionSettings(this);
        }

        // Kund btn
        private void KunderButton_Click(object sender, EventArgs e)
        {
            new KundForm();
        }

        // Leverantör btn
        private void LeverantörButton_Click(object sender, EventArgs e)
        {
            new LeverantörForm();
        }

        // Produkt btn
        private void ProduktButton_Click(object sender, EventArgs e)
        {
            new ProduktForm();
        }

        // Kampan btn
        private void KampanjButton_Click(object sender, EventArgs e)
        {

        }
    }
}
