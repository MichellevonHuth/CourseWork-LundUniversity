namespace Assignment_2
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
            this.allColumnNameButton = new System.Windows.Forms.Button();
            this.numberOfRowsButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // allColumnNameButton
            // 
            this.allColumnNameButton.AutoSize = true;
            this.allColumnNameButton.Location = new System.Drawing.Point(43, 47);
            this.allColumnNameButton.Name = "allColumnNameButton";
            this.allColumnNameButton.Size = new System.Drawing.Size(102, 23);
            this.allColumnNameButton.TabIndex = 0;
            this.allColumnNameButton.Text = "All column names";
            this.allColumnNameButton.UseVisualStyleBackColor = true;
            this.allColumnNameButton.Click += new System.EventHandler(this.AllColumnNameButton_Click);
            // 
            // numberOfRowsButton
            // 
            this.numberOfRowsButton.Location = new System.Drawing.Point(181, 47);
            this.numberOfRowsButton.Name = "numberOfRowsButton";
            this.numberOfRowsButton.Size = new System.Drawing.Size(102, 23);
            this.numberOfRowsButton.TabIndex = 1;
            this.numberOfRowsButton.Text = "Number of rows";
            this.numberOfRowsButton.UseVisualStyleBackColor = true;
            this.numberOfRowsButton.Click += new System.EventHandler(this.NumberOfRowsButton_Click);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Location = new System.Drawing.Point(40, 266);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(243, 23);
            this.errorMessageLabel.TabIndex = 3;
            this.errorMessageLabel.Click += new System.EventHandler(this.errorMessageLabel_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(45, 92);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(238, 180);
            this.textBox.TabIndex = 4;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 305);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.numberOfRowsButton);
            this.Controls.Add(this.allColumnNameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allColumnNameButton;
        private System.Windows.Forms.Button numberOfRowsButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.TextBox textBox;
    }
}