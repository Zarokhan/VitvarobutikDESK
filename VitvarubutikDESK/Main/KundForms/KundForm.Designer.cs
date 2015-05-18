namespace VitvarubutikDESK.Main.FormTables
{
    partial class KundForm
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
            this.listKunder = new System.Windows.Forms.ListBox();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.RedigeraButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listKunder
            // 
            this.listKunder.FormattingEnabled = true;
            this.listKunder.Location = new System.Drawing.Point(12, 12);
            this.listKunder.Name = "listKunder";
            this.listKunder.Size = new System.Drawing.Size(727, 147);
            this.listKunder.TabIndex = 0;
            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(12, 165);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(86, 23);
            this.NewProductButton.TabIndex = 1;
            this.NewProductButton.Text = "Lägg till";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // RedigeraButton
            // 
            this.RedigeraButton.Location = new System.Drawing.Point(104, 165);
            this.RedigeraButton.Name = "RedigeraButton";
            this.RedigeraButton.Size = new System.Drawing.Size(75, 23);
            this.RedigeraButton.TabIndex = 2;
            this.RedigeraButton.Text = "Redigera";
            this.RedigeraButton.UseVisualStyleBackColor = true;
            this.RedigeraButton.Click += new System.EventHandler(this.RedigeraButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(185, 165);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Ta bort";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // KundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 194);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RedigeraButton);
            this.Controls.Add(this.NewProductButton);
            this.Controls.Add(this.listKunder);
            this.Name = "KundForm";
            this.Text = "Kunder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listKunder;
        private System.Windows.Forms.Button NewProductButton;
        private System.Windows.Forms.Button RedigeraButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}