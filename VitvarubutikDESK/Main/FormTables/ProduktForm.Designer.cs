namespace VitvarubutikDESK.Main.FormTables
{
    partial class ProduktForm
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
            this.listProducts = new System.Windows.Forms.ListBox();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProducts
            // 
            this.listProducts.FormattingEnabled = true;
            this.listProducts.Location = new System.Drawing.Point(12, 12);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(727, 147);
            this.listProducts.TabIndex = 0;
            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(12, 303);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(86, 23);
            this.NewProductButton.TabIndex = 1;
            this.NewProductButton.Text = "Lägg till";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // ProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 338);
            this.Controls.Add(this.NewProductButton);
            this.Controls.Add(this.listProducts);
            this.Name = "ProduktForm";
            this.Text = "ProduktForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.Button NewProductButton;
    }
}