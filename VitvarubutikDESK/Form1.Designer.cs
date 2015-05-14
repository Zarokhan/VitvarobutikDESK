namespace VitvarubutikDESK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.databaseinfotext_label = new System.Windows.Forms.Label();
            this.IPtext_label = new System.Windows.Forms.Label();
            this.ipaddress_label = new System.Windows.Forms.Label();
            this.dbtext_label = new System.Windows.Forms.Label();
            this.dbname_label = new System.Windows.Forms.Label();
            this.Usertext_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.PWtext_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.Statustext_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // databaseinfotext_label
            // 
            this.databaseinfotext_label.AutoSize = true;
            this.databaseinfotext_label.Location = new System.Drawing.Point(12, 9);
            this.databaseinfotext_label.Name = "databaseinfotext_label";
            this.databaseinfotext_label.Size = new System.Drawing.Size(77, 13);
            this.databaseinfotext_label.TabIndex = 0;
            this.databaseinfotext_label.Text = "Database Info:";
            // 
            // IPtext_label
            // 
            this.IPtext_label.AutoSize = true;
            this.IPtext_label.Location = new System.Drawing.Point(95, 9);
            this.IPtext_label.Name = "IPtext_label";
            this.IPtext_label.Size = new System.Drawing.Size(20, 13);
            this.IPtext_label.TabIndex = 1;
            this.IPtext_label.Text = "IP:";
            // 
            // ipaddress_label
            // 
            this.ipaddress_label.AutoSize = true;
            this.ipaddress_label.Location = new System.Drawing.Point(121, 9);
            this.ipaddress_label.Name = "ipaddress_label";
            this.ipaddress_label.Size = new System.Drawing.Size(40, 13);
            this.ipaddress_label.TabIndex = 2;
            this.ipaddress_label.Text = "0.0.0.0";
            // 
            // dbtext_label
            // 
            this.dbtext_label.AutoSize = true;
            this.dbtext_label.Location = new System.Drawing.Point(213, 9);
            this.dbtext_label.Name = "dbtext_label";
            this.dbtext_label.Size = new System.Drawing.Size(56, 13);
            this.dbtext_label.TabIndex = 3;
            this.dbtext_label.Text = "Database:";
            // 
            // dbname_label
            // 
            this.dbname_label.AutoSize = true;
            this.dbname_label.Location = new System.Drawing.Point(275, 9);
            this.dbname_label.Name = "dbname_label";
            this.dbname_label.Size = new System.Drawing.Size(51, 13);
            this.dbname_label.TabIndex = 4;
            this.dbname_label.Text = "db_name";
            // 
            // Usertext_label
            // 
            this.Usertext_label.AutoSize = true;
            this.Usertext_label.Location = new System.Drawing.Point(399, 9);
            this.Usertext_label.Name = "Usertext_label";
            this.Usertext_label.Size = new System.Drawing.Size(32, 13);
            this.Usertext_label.TabIndex = 5;
            this.Usertext_label.Text = "User:";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(437, 9);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(53, 13);
            this.username_label.TabIndex = 6;
            this.username_label.Text = "username";
            // 
            // PWtext_label
            // 
            this.PWtext_label.AutoSize = true;
            this.PWtext_label.Location = new System.Drawing.Point(552, 9);
            this.PWtext_label.Name = "PWtext_label";
            this.PWtext_label.Size = new System.Drawing.Size(56, 13);
            this.PWtext_label.TabIndex = 7;
            this.PWtext_label.Text = "Password:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(614, 9);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(52, 13);
            this.password_label.TabIndex = 8;
            this.password_label.Text = "password";
            // 
            // Statustext_label
            // 
            this.Statustext_label.AutoSize = true;
            this.Statustext_label.Location = new System.Drawing.Point(717, 9);
            this.Statustext_label.Name = "Statustext_label";
            this.Statustext_label.Size = new System.Drawing.Size(40, 13);
            this.Statustext_label.TabIndex = 9;
            this.Statustext_label.Text = "Status:";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(763, 9);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(58, 13);
            this.status_label.TabIndex = 10;
            this.status_label.Text = "connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.Statustext_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.PWtext_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.Usertext_label);
            this.Controls.Add(this.dbname_label);
            this.Controls.Add(this.dbtext_label);
            this.Controls.Add(this.ipaddress_label);
            this.Controls.Add(this.IPtext_label);
            this.Controls.Add(this.databaseinfotext_label);
            this.Name = "Form1";
            this.Text = "Vitvarubutik Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label databaseinfotext_label;
        private System.Windows.Forms.Label IPtext_label;
        private System.Windows.Forms.Label ipaddress_label;
        private System.Windows.Forms.Label dbtext_label;
        private System.Windows.Forms.Label dbname_label;
        private System.Windows.Forms.Label Usertext_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label PWtext_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label Statustext_label;
        private System.Windows.Forms.Label status_label;
    }
}

