namespace VitvarubutikDESK.Main.KundForms
{
    partial class SpecifiedKundForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.KundnrLabel = new System.Windows.Forms.Label();
            this.NamnBox = new System.Windows.Forms.TextBox();
            this.TelnrBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kundnr";
            // 
            // KundnrLabel
            // 
            this.KundnrLabel.AutoSize = true;
            this.KundnrLabel.Location = new System.Drawing.Point(65, 9);
            this.KundnrLabel.Name = "KundnrLabel";
            this.KundnrLabel.Size = new System.Drawing.Size(13, 13);
            this.KundnrLabel.TabIndex = 1;
            this.KundnrLabel.Text = "0";
            // 
            // NamnBox
            // 
            this.NamnBox.Location = new System.Drawing.Point(12, 25);
            this.NamnBox.Name = "NamnBox";
            this.NamnBox.Size = new System.Drawing.Size(435, 20);
            this.NamnBox.TabIndex = 2;
            this.NamnBox.Text = "Namn";
            // 
            // TelnrBox
            // 
            this.TelnrBox.Location = new System.Drawing.Point(12, 51);
            this.TelnrBox.Name = "TelnrBox";
            this.TelnrBox.Size = new System.Drawing.Size(435, 20);
            this.TelnrBox.TabIndex = 3;
            this.TelnrBox.Text = "Telefon";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(12, 77);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(435, 20);
            this.AddressBox.TabIndex = 4;
            this.AddressBox.Text = "Address";
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(12, 103);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(435, 20);
            this.MailBox.TabIndex = 5;
            this.MailBox.Text = "Email";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 129);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Lägg till";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SpecifiedKundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 162);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.TelnrBox);
            this.Controls.Add(this.NamnBox);
            this.Controls.Add(this.KundnrLabel);
            this.Controls.Add(this.label1);
            this.Name = "SpecifiedKundForm";
            this.Text = "SpecifiedKundForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KundnrLabel;
        private System.Windows.Forms.TextBox NamnBox;
        private System.Windows.Forms.TextBox TelnrBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.Button AddButton;
    }
}