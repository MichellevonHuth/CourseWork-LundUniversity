namespace WSClient2_Assignment4
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
            this.getAllAccountsButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getAllAccountsButton
            // 
            this.getAllAccountsButton.Location = new System.Drawing.Point(23, 212);
            this.getAllAccountsButton.Name = "getAllAccountsButton";
            this.getAllAccountsButton.Size = new System.Drawing.Size(159, 23);
            this.getAllAccountsButton.TabIndex = 0;
            this.getAllAccountsButton.Text = "Get all accounts";
            this.getAllAccountsButton.UseVisualStyleBackColor = true;
            this.getAllAccountsButton.Click += new System.EventHandler(this.getAllAccountsButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(23, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(366, 186);
            this.textBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 256);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.getAllAccountsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getAllAccountsButton;
        private System.Windows.Forms.TextBox textBox;
    }
}

