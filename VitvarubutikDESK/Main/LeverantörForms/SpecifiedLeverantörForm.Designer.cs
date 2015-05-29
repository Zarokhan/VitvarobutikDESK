namespace VitvarubutikDESK.Main.LeverantörForms
{
    partial class SpecifiedLeverantörForm
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
            this.NamnBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.TelnrBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NamnBox
            // 
            this.NamnBox.Location = new System.Drawing.Point(12, 12);
            this.NamnBox.Name = "NamnBox";
            this.NamnBox.Size = new System.Drawing.Size(194, 20);
            this.NamnBox.TabIndex = 0;
            this.NamnBox.Text = "Namn";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(12, 38);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(194, 20);
            this.AddressBox.TabIndex = 1;
            this.AddressBox.Text = "Address";
            // 
            // TelnrBox
            // 
            this.TelnrBox.Location = new System.Drawing.Point(12, 64);
            this.TelnrBox.Name = "TelnrBox";
            this.TelnrBox.Size = new System.Drawing.Size(194, 20);
            this.TelnrBox.TabIndex = 2;
            this.TelnrBox.Text = "Telefon";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(236, 64);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Lägg till";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SpecifiedLeverantörForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 99);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TelnrBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NamnBox);
            this.Name = "SpecifiedLeverantörForm";
            this.Text = "SpecifiedLeverantörForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NamnBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox TelnrBox;
        private System.Windows.Forms.Button AddButton;
    }
}