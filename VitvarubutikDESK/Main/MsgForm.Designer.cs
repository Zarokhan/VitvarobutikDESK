namespace VitvarubutikDESK.Main
{
    partial class MsgForm
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
            this.WarningText = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WarningText
            // 
            this.WarningText.AutoSize = true;
            this.WarningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningText.Location = new System.Drawing.Point(31, 18);
            this.WarningText.Name = "WarningText";
            this.WarningText.Size = new System.Drawing.Size(234, 17);
            this.WarningText.TabIndex = 0;
            this.WarningText.Text = "WARNING! COULD NOT CONNECT";
            this.WarningText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(107, 47);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "Close";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // ErrorMsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 82);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.WarningText);
            this.Name = "ErrorMsgForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WarningText;
        private System.Windows.Forms.Button OK_Button;
    }
}