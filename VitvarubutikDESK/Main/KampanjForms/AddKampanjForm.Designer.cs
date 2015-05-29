namespace VitvarubutikDESK.Main.KampanjForms
{
    partial class AddKampanjForm
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
            this.ReaBar = new System.Windows.Forms.TrackBar();
            this.BeskrivningText = new System.Windows.Forms.RichTextBox();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReaLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReaBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ReaBar
            // 
            this.ReaBar.Location = new System.Drawing.Point(379, 212);
            this.ReaBar.Maximum = 100;
            this.ReaBar.Name = "ReaBar";
            this.ReaBar.Size = new System.Drawing.Size(387, 45);
            this.ReaBar.TabIndex = 6;
            this.ReaBar.ValueChanged += new System.EventHandler(this.ReaBar_ValueChanged);
            // 
            // BeskrivningText
            // 
            this.BeskrivningText.Location = new System.Drawing.Point(141, 70);
            this.BeskrivningText.Name = "BeskrivningText";
            this.BeskrivningText.Size = new System.Drawing.Size(232, 187);
            this.BeskrivningText.TabIndex = 5;
            this.BeskrivningText.Text = "";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(173, 44);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 20);
            this.EndDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(173, 18);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 20);
            this.StartDate.TabIndex = 1;
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(12, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(120, 251);
            this.ListBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "0 %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "100%";
            // 
            // ReaLabel
            // 
            this.ReaLabel.AutoSize = true;
            this.ReaLabel.Location = new System.Drawing.Point(552, 196);
            this.ReaLabel.Name = "ReaLabel";
            this.ReaLabel.Size = new System.Drawing.Size(21, 13);
            this.ReaLabel.TabIndex = 9;
            this.ReaLabel.Text = "0%";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(691, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Lägg till";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddKampanjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 269);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ReaLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReaBar);
            this.Controls.Add(this.BeskrivningText);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.ListBox);
            this.Name = "AddKampanjForm";
            this.Text = "AddKampanjForm";
            ((System.ComponentModel.ISupportInitialize)(this.ReaBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.RichTextBox BeskrivningText;
        private System.Windows.Forms.TrackBar ReaBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ReaLabel;
        private System.Windows.Forms.Button AddButton;
    }
}