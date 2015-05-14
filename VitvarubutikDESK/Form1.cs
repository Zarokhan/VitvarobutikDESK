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

namespace VitvarubutikDESK
{
    public partial class Form1 : Form
    {
        // Database connection properties
        private String Host = "localhost";
        private String Database = "vitvarubutik";
        private String Username = "Zarokhan";
        private String Password = "F9fSqpyHJRrBvCsA";

        public Form1()
        {
            InitializeComponent();

            // Locked window size
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            Establish_DB_Connection();
        }

        public void Establish_DB_Connection()
        {
            bool Established_Connection = true;
            
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection("server=" + Host + ";uid=" + Username + ";pwd=" + Password + ";database=" + Database + ";");
                conn.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                status_label.Text = "Disconnected";
                Established_Connection = false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            Console.Read();

            if(Established_Connection)
                Update_Label_Texts();
        }

        public void Update_Label_Texts()
        {
            ipaddress_label.Text = Host;
            dbname_label.Text = Database;
            username_label.Text = Username;
            password_label.Text = Password;

        }
    }
}
