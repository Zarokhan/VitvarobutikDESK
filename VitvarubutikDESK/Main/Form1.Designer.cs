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
            this.ConnectionSettings = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.Statustext_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.PWtext_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.Usertext_label = new System.Windows.Forms.Label();
            this.dbname_label = new System.Windows.Forms.Label();
            this.dbtext_label = new System.Windows.Forms.Label();
            this.ipaddress_label = new System.Windows.Forms.Label();
            this.IPtext_label = new System.Windows.Forms.Label();
            this.KunderButton = new System.Windows.Forms.Button();
            this.LeverantörButton = new System.Windows.Forms.Button();
            this.ProduktButton = new System.Windows.Forms.Button();
            this.KampanjButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectionSettings
            // 
            this.ConnectionSettings.Location = new System.Drawing.Point(836, 4);
            this.ConnectionSettings.Name = "ConnectionSettings";
            this.ConnectionSettings.Size = new System.Drawing.Size(112, 23);
            this.ConnectionSettings.TabIndex = 11;
            this.ConnectionSettings.Text = "Connection Settings";
            this.ConnectionSettings.UseVisualStyleBackColor = true;
            this.ConnectionSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConnectionSettings_MouseClick);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(738, 9);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(58, 13);
            this.status_label.TabIndex = 10;
            this.status_label.Text = "connected";
            // 
            // Statustext_label
            // 
            this.Statustext_label.AutoSize = true;
            this.Statustext_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statustext_label.Location = new System.Drawing.Point(685, 9);
            this.Statustext_label.Name = "Statustext_label";
            this.Statustext_label.Size = new System.Drawing.Size(47, 13);
            this.Statustext_label.TabIndex = 9;
            this.Statustext_label.Text = "Status:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(550, 9);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(52, 13);
            this.password_label.TabIndex = 8;
            this.password_label.Text = "password";
            // 
            // PWtext_label
            // 
            this.PWtext_label.AutoSize = true;
            this.PWtext_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWtext_label.Location = new System.Drawing.Point(488, 9);
            this.PWtext_label.Name = "PWtext_label";
            this.PWtext_label.Size = new System.Drawing.Size(65, 13);
            this.PWtext_label.TabIndex = 7;
            this.PWtext_label.Text = "Password:";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(398, 9);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(53, 13);
            this.username_label.TabIndex = 6;
            this.username_label.Text = "username";
            // 
            // Usertext_label
            // 
            this.Usertext_label.AutoSize = true;
            this.Usertext_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertext_label.Location = new System.Drawing.Point(360, 9);
            this.Usertext_label.Name = "Usertext_label";
            this.Usertext_label.Size = new System.Drawing.Size(37, 13);
            this.Usertext_label.TabIndex = 5;
            this.Usertext_label.Text = "User:";
            // 
            // dbname_label
            // 
            this.dbname_label.AutoSize = true;
            this.dbname_label.Location = new System.Drawing.Point(271, 9);
            this.dbname_label.Name = "dbname_label";
            this.dbname_label.Size = new System.Drawing.Size(51, 13);
            this.dbname_label.TabIndex = 4;
            this.dbname_label.Text = "db_name";
            // 
            // dbtext_label
            // 
            this.dbtext_label.AutoSize = true;
            this.dbtext_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbtext_label.Location = new System.Drawing.Point(209, 9);
            this.dbtext_label.Name = "dbtext_label";
            this.dbtext_label.Size = new System.Drawing.Size(65, 13);
            this.dbtext_label.TabIndex = 3;
            this.dbtext_label.Text = "Database:";
            // 
            // ipaddress_label
            // 
            this.ipaddress_label.AutoSize = true;
            this.ipaddress_label.Location = new System.Drawing.Point(135, 9);
            this.ipaddress_label.Name = "ipaddress_label";
            this.ipaddress_label.Size = new System.Drawing.Size(40, 13);
            this.ipaddress_label.TabIndex = 2;
            this.ipaddress_label.Text = "0.0.0.0";
            // 
            // IPtext_label
            // 
            this.IPtext_label.AutoSize = true;
            this.IPtext_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPtext_label.Location = new System.Drawing.Point(109, 9);
            this.IPtext_label.Name = "IPtext_label";
            this.IPtext_label.Size = new System.Drawing.Size(23, 13);
            this.IPtext_label.TabIndex = 1;
            this.IPtext_label.Text = "IP:";
            // 
            // KunderButton
            // 
            this.KunderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KunderButton.Location = new System.Drawing.Point(183, 292);
            this.KunderButton.Name = "KunderButton";
            this.KunderButton.Size = new System.Drawing.Size(250, 115);
            this.KunderButton.TabIndex = 12;
            this.KunderButton.Text = "Kunder";
            this.KunderButton.UseVisualStyleBackColor = true;
            this.KunderButton.Click += new System.EventHandler(this.KunderButton_Click);
            // 
            // LeverantörButton
            // 
            this.LeverantörButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeverantörButton.Location = new System.Drawing.Point(439, 292);
            this.LeverantörButton.Name = "LeverantörButton";
            this.LeverantörButton.Size = new System.Drawing.Size(250, 115);
            this.LeverantörButton.TabIndex = 13;
            this.LeverantörButton.Text = "Leverantörer";
            this.LeverantörButton.UseVisualStyleBackColor = true;
            this.LeverantörButton.Click += new System.EventHandler(this.LeverantörButton_Click);
            // 
            // ProduktButton
            // 
            this.ProduktButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProduktButton.Location = new System.Drawing.Point(183, 413);
            this.ProduktButton.Name = "ProduktButton";
            this.ProduktButton.Size = new System.Drawing.Size(250, 115);
            this.ProduktButton.TabIndex = 14;
            this.ProduktButton.Text = "Produkter";
            this.ProduktButton.UseVisualStyleBackColor = true;
            this.ProduktButton.Click += new System.EventHandler(this.ProduktButton_Click);
            // 
            // KampanjButton
            // 
            this.KampanjButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KampanjButton.Location = new System.Drawing.Point(439, 413);
            this.KampanjButton.Name = "KampanjButton";
            this.KampanjButton.Size = new System.Drawing.Size(250, 115);
            this.KampanjButton.TabIndex = 15;
            this.KampanjButton.Text = "Kampanjer";
            this.KampanjButton.UseVisualStyleBackColor = true;
            this.KampanjButton.Click += new System.EventHandler(this.KampanjButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.KampanjButton);
            this.Controls.Add(this.ProduktButton);
            this.Controls.Add(this.LeverantörButton);
            this.Controls.Add(this.KunderButton);
            this.Controls.Add(this.ConnectionSettings);
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
            this.Name = "Form1";
            this.Text = "Vitvarubutik Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button ConnectionSettings;
        private System.Windows.Forms.Button KunderButton;
        private System.Windows.Forms.Button LeverantörButton;
        private System.Windows.Forms.Button ProduktButton;
        private System.Windows.Forms.Button KampanjButton;
    }
}

