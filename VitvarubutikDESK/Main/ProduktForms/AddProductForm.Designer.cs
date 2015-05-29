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
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.EnergiTextBox = new System.Windows.Forms.TextBox();
            this.BeskrivningTextBox = new System.Windows.Forms.RichTextBox();
            this.PrisTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AntalTextBox = new System.Windows.Forms.TextBox();
            this.ImageTextBox = new System.Windows.Forms.TextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.listProduktTyp = new System.Windows.Forms.ListBox();
            this.listTillverkare = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProduktButton = new System.Windows.Forms.Button();
            this.AddTillverkareButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(264, 12);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModelTextBox.TabIndex = 2;
            this.ModelTextBox.Text = "Model";
            // 
            // EnergiTextBox
            // 
            this.EnergiTextBox.Location = new System.Drawing.Point(264, 38);
            this.EnergiTextBox.Name = "EnergiTextBox";
            this.EnergiTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnergiTextBox.TabIndex = 3;
            this.EnergiTextBox.Text = "Energiklass";
            // 
            // BeskrivningTextBox
            // 
            this.BeskrivningTextBox.Location = new System.Drawing.Point(370, 12);
            this.BeskrivningTextBox.Name = "BeskrivningTextBox";
            this.BeskrivningTextBox.Size = new System.Drawing.Size(214, 137);
            this.BeskrivningTextBox.TabIndex = 6;
            this.BeskrivningTextBox.Text = "Beskrivning";
            // 
            // PrisTextBox
            // 
            this.PrisTextBox.Location = new System.Drawing.Point(264, 93);
            this.PrisTextBox.Name = "PrisTextBox";
            this.PrisTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrisTextBox.TabIndex = 4;
            this.PrisTextBox.Text = "Pris";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 187);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 42);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Lägg till";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AntalTextBox
            // 
            this.AntalTextBox.Location = new System.Drawing.Point(264, 119);
            this.AntalTextBox.Name = "AntalTextBox";
            this.AntalTextBox.Size = new System.Drawing.Size(100, 20);
            this.AntalTextBox.TabIndex = 5;
            this.AntalTextBox.Text = "Antal";
            // 
            // ImageTextBox
            // 
            this.ImageTextBox.Location = new System.Drawing.Point(370, 155);
            this.ImageTextBox.Name = "ImageTextBox";
            this.ImageTextBox.Size = new System.Drawing.Size(357, 20);
            this.ImageTextBox.TabIndex = 7;
            this.ImageTextBox.Text = "Bild Länk";
            this.ImageTextBox.Leave += new System.EventHandler(this.ImageTextBox_Leave);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(590, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(137, 137);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 9;
            this.PictureBox.TabStop = false;
            // 
            // listProduktTyp
            // 
            this.listProduktTyp.FormattingEnabled = true;
            this.listProduktTyp.Location = new System.Drawing.Point(12, 12);
            this.listProduktTyp.Name = "listProduktTyp";
            this.listProduktTyp.Size = new System.Drawing.Size(120, 134);
            this.listProduktTyp.TabIndex = 0;
            // 
            // listTillverkare
            // 
            this.listTillverkare.FormattingEnabled = true;
            this.listTillverkare.Location = new System.Drawing.Point(138, 12);
            this.listTillverkare.Name = "listTillverkare";
            this.listTillverkare.Size = new System.Drawing.Size(120, 134);
            this.listTillverkare.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ProduktTyp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tillverkare";
            // 
            // AddProduktButton
            // 
            this.AddProduktButton.Location = new System.Drawing.Point(83, 149);
            this.AddProduktButton.Name = "AddProduktButton";
            this.AddProduktButton.Size = new System.Drawing.Size(49, 24);
            this.AddProduktButton.TabIndex = 9;
            this.AddProduktButton.Text = "Add";
            this.AddProduktButton.UseVisualStyleBackColor = true;
            this.AddProduktButton.Click += new System.EventHandler(this.AddProduktButton_Click);
            // 
            // AddTillverkareButton
            // 
            this.AddTillverkareButton.Location = new System.Drawing.Point(209, 149);
            this.AddTillverkareButton.Name = "AddTillverkareButton";
            this.AddTillverkareButton.Size = new System.Drawing.Size(49, 24);
            this.AddTillverkareButton.TabIndex = 10;
            this.AddTillverkareButton.Text = "Add";
            this.AddTillverkareButton.UseVisualStyleBackColor = true;
            this.AddTillverkareButton.Click += new System.EventHandler(this.AddTillverkareButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 241);
            this.Controls.Add(this.AddTillverkareButton);
            this.Controls.Add(this.AddProduktButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listTillverkare);
            this.Controls.Add(this.listProduktTyp);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ImageTextBox);
            this.Controls.Add(this.AntalTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PrisTextBox);
            this.Controls.Add(this.BeskrivningTextBox);
            this.Controls.Add(this.EnergiTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Name = "AddProductForm";
            this.Text = "Produkt";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox EnergiTextBox;
        private System.Windows.Forms.RichTextBox BeskrivningTextBox;
        private System.Windows.Forms.TextBox PrisTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AntalTextBox;
        private System.Windows.Forms.TextBox ImageTextBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ListBox listProduktTyp;
        private System.Windows.Forms.ListBox listTillverkare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProduktButton;
        private System.Windows.Forms.Button AddTillverkareButton;
    }
}