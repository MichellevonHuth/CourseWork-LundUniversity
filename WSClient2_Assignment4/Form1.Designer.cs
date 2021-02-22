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
            this.getAllSchedulesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getAllAccountsButton
            // 
            this.getAllAccountsButton.Location = new System.Drawing.Point(140, 301);
            this.getAllAccountsButton.Name = "getAllAccountsButton";
            this.getAllAccountsButton.Size = new System.Drawing.Size(198, 23);
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
            this.textBox.Size = new System.Drawing.Size(644, 273);
            this.textBox.TabIndex = 1;
            // 
            // getAllSchedulesButton
            // 
            this.getAllSchedulesButton.Location = new System.Drawing.Point(383, 301);
            this.getAllSchedulesButton.Name = "getAllSchedulesButton";
            this.getAllSchedulesButton.Size = new System.Drawing.Size(185, 23);
            this.getAllSchedulesButton.TabIndex = 2;
            this.getAllSchedulesButton.Text = "Get all savingschedules";
            this.getAllSchedulesButton.UseVisualStyleBackColor = true;
            this.getAllSchedulesButton.Click += new System.EventHandler(this.getAllSchedulesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 359);
            this.Controls.Add(this.getAllSchedulesButton);
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
        private System.Windows.Forms.Button getAllSchedulesButton;
    }
}

