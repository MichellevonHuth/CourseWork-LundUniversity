namespace MyDesktopApp
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurenameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.SurenameTextbox = new System.Windows.Forms.TextBox();
            this.AgeTextbox = new System.Windows.Forms.TextBox();
            this.Form1NextButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(63, 39);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(215, 45);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome! ";
            this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(129, 178);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // SurenameLabel
            // 
            this.SurenameLabel.AutoSize = true;
            this.SurenameLabel.Location = new System.Drawing.Point(129, 260);
            this.SurenameLabel.Name = "SurenameLabel";
            this.SurenameLabel.Size = new System.Drawing.Size(116, 25);
            this.SurenameLabel.TabIndex = 2;
            this.SurenameLabel.Text = "Surename:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(129, 342);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(50, 25);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Age";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(262, 178);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 31);
            this.NameTextbox.TabIndex = 4;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // SurenameTextbox
            // 
            this.SurenameTextbox.Location = new System.Drawing.Point(262, 254);
            this.SurenameTextbox.Name = "SurenameTextbox";
            this.SurenameTextbox.Size = new System.Drawing.Size(100, 31);
            this.SurenameTextbox.TabIndex = 5;
            this.SurenameTextbox.TextChanged += new System.EventHandler(this.SurenameTextbox_TextChanged);
            // 
            // AgeTextbox
            // 
            this.AgeTextbox.Location = new System.Drawing.Point(262, 336);
            this.AgeTextbox.Name = "AgeTextbox";
            this.AgeTextbox.Size = new System.Drawing.Size(100, 31);
            this.AgeTextbox.TabIndex = 6;
            this.AgeTextbox.TextChanged += new System.EventHandler(this.AgeTextbox_TextChanged);
            // 
            // Form1NextButton
            // 
            this.Form1NextButton.Location = new System.Drawing.Point(540, 427);
            this.Form1NextButton.Name = "Form1NextButton";
            this.Form1NextButton.Size = new System.Drawing.Size(159, 52);
            this.Form1NextButton.TabIndex = 7;
            this.Form1NextButton.Text = "Next";
            this.Form1NextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Form1NextButton.UseVisualStyleBackColor = true;
            this.Form1NextButton.Click += new System.EventHandler(this.Form1NextButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(66, 106);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(308, 25);
            this.HeaderLabel.TabIndex = 8;
            this.HeaderLabel.Text = "Please fill in information below:";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 551);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.Form1NextButton);
            this.Controls.Add(this.AgeTextbox);
            this.Controls.Add(this.SurenameTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.SurenameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurenameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox SurenameTextbox;
        private System.Windows.Forms.TextBox AgeTextbox;
        private System.Windows.Forms.Button Form1NextButton;
        private System.Windows.Forms.Label HeaderLabel;
    }
}