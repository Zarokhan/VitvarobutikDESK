namespace VitvarubutikDESK.Main.FormTables
{
    partial class AddKundForm
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
            this.NamnTextBox = new System.Windows.Forms.TextBox();
            this.NummerTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NamnTextBox
            // 
            this.NamnTextBox.Location = new System.Drawing.Point(12, 12);
            this.NamnTextBox.Name = "NamnTextBox";
            this.NamnTextBox.Size = new System.Drawing.Size(310, 20);
            this.NamnTextBox.TabIndex = 0;
            this.NamnTextBox.Text = "Namn";
            // 
            // NummerTextBox
            // 
            this.NummerTextBox.Location = new System.Drawing.Point(12, 38);
            this.NummerTextBox.Name = "NummerTextBox";
            this.NummerTextBox.Size = new System.Drawing.Size(310, 20);
            this.NummerTextBox.TabIndex = 1;
            this.NummerTextBox.Text = "Telnummer";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(12, 90);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(310, 20);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.Text = "Email";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 116);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 42);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Lägg till";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(12, 64);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(310, 20);
            this.AddressTextBox.TabIndex = 2;
            this.AddressTextBox.Text = "Address";
            // 
            // AddKundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 168);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NummerTextBox);
            this.Controls.Add(this.NamnTextBox);
            this.Name = "AddKundForm";
            this.Text = "Kund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NamnTextBox;
        private System.Windows.Forms.TextBox NummerTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddressTextBox;
    }
}