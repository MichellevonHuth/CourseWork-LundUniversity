
namespace Assignment2
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
            this.nbrOfRows_Btn = new System.Windows.Forms.Button();
            this.message_txtB = new System.Windows.Forms.TextBox();
            this.allColumnNames_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nbrOfRows_Btn
            // 
            this.nbrOfRows_Btn.Location = new System.Drawing.Point(189, 90);
            this.nbrOfRows_Btn.Name = "nbrOfRows_Btn";
            this.nbrOfRows_Btn.Size = new System.Drawing.Size(189, 82);
            this.nbrOfRows_Btn.TabIndex = 0;
            this.nbrOfRows_Btn.Text = "Number of rows";
            this.nbrOfRows_Btn.UseVisualStyleBackColor = true;
            this.nbrOfRows_Btn.Click += new System.EventHandler(this.nbrOfRows_Btn_Click);
            // 
            // message_txtB
            // 
            this.message_txtB.Location = new System.Drawing.Point(197, 214);
            this.message_txtB.Multiline = true;
            this.message_txtB.Name = "message_txtB";
            this.message_txtB.Size = new System.Drawing.Size(466, 188);
            this.message_txtB.TabIndex = 2;
            this.message_txtB.TextChanged += new System.EventHandler(this.message_txtB_TextChanged);
            // 
            // allColumnNames_Btn
            // 
            this.allColumnNames_Btn.Location = new System.Drawing.Point(469, 90);
            this.allColumnNames_Btn.Name = "allColumnNames_Btn";
            this.allColumnNames_Btn.Size = new System.Drawing.Size(182, 81);
            this.allColumnNames_Btn.TabIndex = 3;
            this.allColumnNames_Btn.Text = "All column names";
            this.allColumnNames_Btn.UseVisualStyleBackColor = true;
            this.allColumnNames_Btn.Click += new System.EventHandler(this.allColumnNames_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allColumnNames_Btn);
            this.Controls.Add(this.message_txtB);
            this.Controls.Add(this.nbrOfRows_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nbrOfRows_Btn;
        private System.Windows.Forms.TextBox message_txtB;
        private System.Windows.Forms.Button allColumnNames_Btn;

   
    }
}