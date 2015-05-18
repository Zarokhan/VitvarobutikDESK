namespace VitvarubutikDESK.Main.FormTables
{
    partial class AddProductForm
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
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.TillverkareTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.EnergiTextBox = new System.Windows.Forms.TextBox();
            this.BeskrivningTextBox = new System.Windows.Forms.RichTextBox();
            this.PrisTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AntalTextBox = new System.Windows.Forms.TextBox();
            this.ImageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(118, 12);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TypeTextBox.TabIndex = 1;
            this.TypeTextBox.Text = "Produkt Typ";
            // 
            // TillverkareTextBox
            // 
            this.TillverkareTextBox.Location = new System.Drawing.Point(12, 12);
            this.TillverkareTextBox.Name = "TillverkareTextBox";
            this.TillverkareTextBox.Size = new System.Drawing.Size(100, 20);
            this.TillverkareTextBox.TabIndex = 0;
            this.TillverkareTextBox.Text = "Tillverkare";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(224, 12);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModelTextBox.TabIndex = 2;
            this.ModelTextBox.Text = "Model";
            // 
            // EnergiTextBox
            // 
            this.EnergiTextBox.Location = new System.Drawing.Point(12, 38);
            this.EnergiTextBox.Name = "EnergiTextBox";
            this.EnergiTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnergiTextBox.TabIndex = 3;
            this.EnergiTextBox.Text = "Energiklass";
            // 
            // BeskrivningTextBox
            // 
            this.BeskrivningTextBox.Location = new System.Drawing.Point(330, 12);
            this.BeskrivningTextBox.Name = "BeskrivningTextBox";
            this.BeskrivningTextBox.Size = new System.Drawing.Size(214, 137);
            this.BeskrivningTextBox.TabIndex = 7;
            this.BeskrivningTextBox.Text = "Beskrivning";
            // 
            // PrisTextBox
            // 
            this.PrisTextBox.Location = new System.Drawing.Point(118, 38);
            this.PrisTextBox.Name = "PrisTextBox";
            this.PrisTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrisTextBox.TabIndex = 4;
            this.PrisTextBox.Text = "Pris";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 107);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 42);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Lägg till";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AntalTextBox
            // 
            this.AntalTextBox.Location = new System.Drawing.Point(224, 38);
            this.AntalTextBox.Name = "AntalTextBox";
            this.AntalTextBox.Size = new System.Drawing.Size(100, 20);
            this.AntalTextBox.TabIndex = 5;
            this.AntalTextBox.Text = "Antal";
            // 
            // ImageTextBox
            // 
            this.ImageTextBox.Location = new System.Drawing.Point(12, 64);
            this.ImageTextBox.Name = "ImageTextBox";
            this.ImageTextBox.Size = new System.Drawing.Size(312, 20);
            this.ImageTextBox.TabIndex = 6;
            this.ImageTextBox.Text = "Bild Länk";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 161);
            this.Controls.Add(this.ImageTextBox);
            this.Controls.Add(this.AntalTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PrisTextBox);
            this.Controls.Add(this.BeskrivningTextBox);
            this.Controls.Add(this.EnergiTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.TillverkareTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Name = "AddProductForm";
            this.Text = "Produkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox TillverkareTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox EnergiTextBox;
        private System.Windows.Forms.RichTextBox BeskrivningTextBox;
        private System.Windows.Forms.TextBox PrisTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AntalTextBox;
        private System.Windows.Forms.TextBox ImageTextBox;
    }
}