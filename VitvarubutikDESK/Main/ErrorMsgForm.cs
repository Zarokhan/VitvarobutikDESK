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
    public partial class ErrorMsgForm : FixedForm
    {
        private String ErrorMsg;

        public ErrorMsgForm(String errorMsg)
        {
            InitializeComponent();

            this.ErrorMsg = errorMsg;
            this.Show();
            this.CenterMessage();
        }

        private void CenterMessage()
        {
            WarningText.Text = ErrorMsg;

            WarningText.PointToScreen(new Point((this.Width - WarningText.Width)/2, (this.Height - WarningText.Height)/2));
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
