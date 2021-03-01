namespace WSClient2_Assignment3
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
            this.getFileButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.errorMessageLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getFileButton
            // 
            this.getFileButton.Location = new System.Drawing.Point(145, 244);
            this.getFileButton.Name = "getFileButton";
            this.getFileButton.Size = new System.Drawing.Size(75, 23);
            this.getFileButton.TabIndex = 0;
            this.getFileButton.Text = "Get file";
            this.getFileButton.UseVisualStyleBackColor = true;
            this.getFileButton.Click += new System.EventHandler(this.getFileButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(51, 32);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(270, 206);
            this.textBox.TabIndex = 1;
            // 
            // errorMessageLbl
            // 
            this.errorMessageLbl.AutoSize = true;
            this.errorMessageLbl.Location = new System.Drawing.Point(116, 275);
            this.errorMessageLbl.Name = "errorMessageLbl";
            this.errorMessageLbl.Size = new System.Drawing.Size(0, 13);
            this.errorMessageLbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 309);
            this.Controls.Add(this.errorMessageLbl);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.getFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getFileButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label errorMessageLbl;
    }
}

