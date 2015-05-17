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

namespace VitvarubutikDESK
{
    public partial class Form1 : FixedForm
    {
        // Database connection properties
        private String Host = "localhost";
        private String Database = "vitvarubutik";
        private String Username = "Zarokhan";
        private String Password = "Q8PtEYNAt7RxBZ5e";

        private String Query = "";

        private ErrorMsgForm ErrorForm;

        public Form1()
        {
            InitializeComponent();

            Establish_DB_Connection();

        }

        public void SetQuery(String query)
        {
            this.Query = query;
        }

        public List<String> ListValuesProductID(int id)
        {
            MySqlConnection conn = null;
            List<String> asdasd = new List<String>();
            try
            {
                conn = new MySqlConnection("server=" + Host + ";uid=" + Username + ";pwd=" + Password + ";database=" + Database + ";");
                conn.Open();

                Query = "SELECT * FROM produkt WHERE id = " + id;

                // SQL Query
                if (Query != "")
                {
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        asdasd.Add(reader.GetString(0));
                        asdasd.Add(reader.GetString(1));
                        asdasd.Add(reader.GetString(2));
                        asdasd.Add(reader.GetString(3));
                        asdasd.Add(reader.GetString(4));
                        asdasd.Add(reader.GetString(5));
                        asdasd.Add(reader.GetString(6));
                        asdasd.Add(reader.GetString(7));
                        asdasd.Add(reader.GetString(8));
                    }

                    reader.Close();
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                status_label.Text = "Disconnected";
                status_label.ForeColor = Color.Red;
                ErrorForm = new ErrorMsgForm("A connection was not established.");
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            return asdasd;
        }

        public List<int> ListAllProducts(ListBox listProducts)
        {
            MySqlConnection conn = null;
            List<int> asdasd = new List<int>();
            try
            {
                conn = new MySqlConnection("server=" + Host + ";uid=" + Username + ";pwd=" + Password + ";database=" + Database + ";");
                conn.Open();

                Query = "SELECT produkt_typ, tillverkare, model, energiklass, id FROM produkt";

                // SQL Query
                if (Query != "")
                {
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Console.WriteLine(reader.GetString(1));
                        string line = reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                        asdasd.Add(reader.GetInt32(4));
                        listProducts.Items.Add(line);
                    }

                    reader.Close();
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                status_label.Text = "Disconnected";
                status_label.ForeColor = Color.Red;
                ErrorForm = new ErrorMsgForm("A connection was not established.");
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            return asdasd;
        }

        public void Establish_DB_Connection()
        {
            bool Established_Connection = false;

            MySqlConnection conn = null;
            try
            {
                Established_Connection = true;
                conn = new MySqlConnection("server=" + Host + ";uid=" + Username + ";pwd=" + Password + ";database=" + Database + ";");
                conn.Open();

                // SQL Query
                if (Query != "")
                {
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    cmd.Prepare();
                    cmd.ExecuteReader();
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                status_label.Text = "Disconnected";
                status_label.ForeColor = Color.Red;
                Established_Connection = false;
                ErrorForm = new ErrorMsgForm("A connection was not established.");
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            if (Established_Connection)
            {
                status_label.Text = "Connected";
                status_label.ForeColor = Color.Green;
                Update_Label_Texts();
            }
            Console.Read();
        }

        public void Update_Label_Texts()
        {
            ipaddress_label.Text = Host;
            dbname_label.Text = Database;
            username_label.Text = Username;
            password_label.Text = Password;

        }

        // Sets new vaules for a sql connection
        public void SetSQLConnection(String host, String DB, String user, String pass)
        {
            this.Host = host;
            this.Database = DB;
            this.Username = user;
            this.Password = pass;

            Establish_DB_Connection();
            Update_Label_Texts();
        }


        // Open up Connection Settings
        private void ConnectionSettings_MouseClick(object sender, MouseEventArgs e)
        {
            ConnectionSettings s = new ConnectionSettings(this);
        }

        private void KunderButton_Click(object sender, EventArgs e)
        {

        }

        private void LeverantörButton_Click(object sender, EventArgs e)
        {

        }

        private void ProduktButton_Click(object sender, EventArgs e)
        {
            ProduktForm pf = new ProduktForm(this);
        }

        private void KampanjButton_Click(object sender, EventArgs e)
        {

        }
    }
}
