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
            this.numberOfRows_btn = new System.Windows.Forms.Button();
            this.allColumnName_btn = new System.Windows.Forms.Button();
            this.messageDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.messageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfRows_btn
            // 
            this.numberOfRows_btn.Location = new System.Drawing.Point(226, 40);
            this.numberOfRows_btn.Name = "numberOfRows_btn";
            this.numberOfRows_btn.Size = new System.Drawing.Size(110, 28);
            this.numberOfRows_btn.TabIndex = 0;
            this.numberOfRows_btn.Text = "Number of rows";
            this.numberOfRows_btn.UseVisualStyleBackColor = true;
            this.numberOfRows_btn.Click += new System.EventHandler(this.numberOfRows_btn_Click);
            // 
            // allColumnName_btn
            // 
            this.allColumnName_btn.Location = new System.Drawing.Point(78, 40);
            this.allColumnName_btn.Name = "allColumnName_btn";
            this.allColumnName_btn.Size = new System.Drawing.Size(109, 28);
            this.allColumnName_btn.TabIndex = 1;
            this.allColumnName_btn.Text = "All column name";
            this.allColumnName_btn.UseVisualStyleBackColor = true;
            this.allColumnName_btn.Click += new System.EventHandler(this.allColumnName_btn_Click);
            // 
            // messageDataGridView
            // 
            this.messageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageDataGridView.Location = new System.Drawing.Point(78, 99);
            this.messageDataGridView.Name = "messageDataGridView";
            this.messageDataGridView.Size = new System.Drawing.Size(258, 163);
            this.messageDataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 292);
            this.Controls.Add(this.messageDataGridView);
            this.Controls.Add(this.allColumnName_btn);
            this.Controls.Add(this.numberOfRows_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.messageDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button numberOfRows_btn;
        private System.Windows.Forms.Button allColumnName_btn;
        private System.Windows.Forms.DataGridView messageDataGridView;
    }
}

