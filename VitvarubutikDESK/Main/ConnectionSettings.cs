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

namespace VitvarubutikDESK.Main
{
    public partial class ConnectionSettings : FixedForm
    {
        Form1 main;

        public ConnectionSettings(Form1 main)
        {
            this.main = main;
            InitializeComponent();

            this.Show();
        }

        private void ConnectionSettings_Load(object sender, EventArgs e)
        {
            HostTextBox.Text = "127.0.0.1";
            DatabaseTextBox.Text = "vitvarubutik";
            UsernameTextBox.Text = "root";
            PasswordTextbox.Text = "";
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form1.Host = HostTextBox.Text;
            Form1.Database = DatabaseTextBox.Text;
            Form1.Username = UsernameTextBox.Text;
            Form1.Password = PasswordTextbox.Text;

            main.CheckConnection();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
