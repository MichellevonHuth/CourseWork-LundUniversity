namespace ERPClient1_Assignment6
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelGetInformation = new System.Windows.Forms.Label();
            this.buttonEmployeeMetadata = new System.Windows.Forms.Button();
            this.buttonEmployeeRelatives = new System.Windows.Forms.Button();
            this.buttonEmployeeAbsent2004 = new System.Windows.Forms.Button();
            this.buttonEmployeeAbsentMost = new System.Windows.Forms.Button();
            this.labelMetadata = new System.Windows.Forms.Label();
            this.buttonAllKeys = new System.Windows.Forms.Button();
            this.buttonAllIndexes = new System.Windows.Forms.Button();
            this.buttonAllConstraints = new System.Windows.Forms.Button();
            this.labelGetTables = new System.Windows.Forms.Label();
            this.buttonAllTables1 = new System.Windows.Forms.Button();
            this.buttonAllTables2 = new System.Windows.Forms.Button();
            this.labelEmployeeTables = new System.Windows.Forms.Label();
            this.buttonGetColumns1 = new System.Windows.Forms.Button();
            this.buttonGetColumns2 = new System.Windows.Forms.Button();
            this.errorMessageLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(253, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(286, 366);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // labelGetInformation
            // 
            this.labelGetInformation.AutoSize = true;
            this.labelGetInformation.Location = new System.Drawing.Point(83, 60);
            this.labelGetInformation.Name = "labelGetInformation";
            this.labelGetInformation.Size = new System.Drawing.Size(108, 13);
            this.labelGetInformation.TabIndex = 1;
            this.labelGetInformation.Text = "Get information about";
            this.labelGetInformation.Click += new System.EventHandler(this.labelGetInformation_Click);
            // 
            // buttonEmployeeMetadata
            // 
            this.buttonEmployeeMetadata.Location = new System.Drawing.Point(29, 90);
            this.buttonEmployeeMetadata.Name = "buttonEmployeeMetadata";
            this.buttonEmployeeMetadata.Size = new System.Drawing.Size(201, 23);
            this.buttonEmployeeMetadata.TabIndex = 2;
            this.buttonEmployeeMetadata.Text = "Employee tables";
            this.buttonEmployeeMetadata.UseVisualStyleBackColor = true;
            this.buttonEmployeeMetadata.Click += new System.EventHandler(this.buttonEmployeeMetadata_Click);
            // 
            // buttonEmployeeRelatives
            // 
            this.buttonEmployeeRelatives.Location = new System.Drawing.Point(29, 146);
            this.buttonEmployeeRelatives.Name = "buttonEmployeeRelatives";
            this.buttonEmployeeRelatives.Size = new System.Drawing.Size(201, 23);
            this.buttonEmployeeRelatives.TabIndex = 3;
            this.buttonEmployeeRelatives.Text = "Employee relatives";
            this.buttonEmployeeRelatives.UseVisualStyleBackColor = true;
            this.buttonEmployeeRelatives.Click += new System.EventHandler(this.buttonEmployeeRelatives_Click);
            // 
            // buttonEmployeeAbsent2004
            // 
            this.buttonEmployeeAbsent2004.Location = new System.Drawing.Point(29, 200);
            this.buttonEmployeeAbsent2004.Name = "buttonEmployeeAbsent2004";
            this.buttonEmployeeAbsent2004.Size = new System.Drawing.Size(201, 23);
            this.buttonEmployeeAbsent2004.TabIndex = 4;
            this.buttonEmployeeAbsent2004.Text = "Employee absent due to sickness";
            this.buttonEmployeeAbsent2004.UseVisualStyleBackColor = true;
            this.buttonEmployeeAbsent2004.Click += new System.EventHandler(this.buttonEmployeeAbsent2004_Click);
            // 
            // buttonEmployeeAbsentMost
            // 
            this.buttonEmployeeAbsentMost.Location = new System.Drawing.Point(29, 254);
            this.buttonEmployeeAbsentMost.Name = "buttonEmployeeAbsentMost";
            this.buttonEmployeeAbsentMost.Size = new System.Drawing.Size(201, 23);
            this.buttonEmployeeAbsentMost.TabIndex = 5;
            this.buttonEmployeeAbsentMost.Text = "Employee absent the most";
            this.buttonEmployeeAbsentMost.UseVisualStyleBackColor = true;
            this.buttonEmployeeAbsentMost.Click += new System.EventHandler(this.buttonEmployeeAbsentMost_Click);
            // 
            // labelMetadata
            // 
            this.labelMetadata.AutoSize = true;
            this.labelMetadata.Location = new System.Drawing.Point(630, 50);
            this.labelMetadata.Name = "labelMetadata";
            this.labelMetadata.Size = new System.Drawing.Size(101, 13);
            this.labelMetadata.TabIndex = 6;
            this.labelMetadata.Text = "Get metadata about";
            this.labelMetadata.Click += new System.EventHandler(this.labelMetadata_Click);
            // 
            // buttonAllKeys
            // 
            this.buttonAllKeys.Location = new System.Drawing.Point(587, 90);
            this.buttonAllKeys.Name = "buttonAllKeys";
            this.buttonAllKeys.Size = new System.Drawing.Size(201, 23);
            this.buttonAllKeys.TabIndex = 7;
            this.buttonAllKeys.Text = "All keys";
            this.buttonAllKeys.UseVisualStyleBackColor = true;
            this.buttonAllKeys.Click += new System.EventHandler(this.buttonAllKeys_Click);
            // 
            // buttonAllIndexes
            // 
            this.buttonAllIndexes.Location = new System.Drawing.Point(587, 132);
            this.buttonAllIndexes.Name = "buttonAllIndexes";
            this.buttonAllIndexes.Size = new System.Drawing.Size(201, 23);
            this.buttonAllIndexes.TabIndex = 8;
            this.buttonAllIndexes.Text = "All indexes";
            this.buttonAllIndexes.UseVisualStyleBackColor = true;
            this.buttonAllIndexes.Click += new System.EventHandler(this.buttonAllIndexes_Click);
            // 
            // buttonAllConstraints
            // 
            this.buttonAllConstraints.Location = new System.Drawing.Point(587, 180);
            this.buttonAllConstraints.Name = "buttonAllConstraints";
            this.buttonAllConstraints.Size = new System.Drawing.Size(201, 23);
            this.buttonAllConstraints.TabIndex = 9;
            this.buttonAllConstraints.Text = "All tables constraint";
            this.buttonAllConstraints.UseVisualStyleBackColor = true;
            this.buttonAllConstraints.Click += new System.EventHandler(this.buttonAllConstraints_Click);
            // 
            // labelGetTables
            // 
            this.labelGetTables.AutoSize = true;
            this.labelGetTables.Location = new System.Drawing.Point(630, 227);
            this.labelGetTables.Name = "labelGetTables";
            this.labelGetTables.Size = new System.Drawing.Size(68, 13);
            this.labelGetTables.TabIndex = 10;
            this.labelGetTables.Text = "Get all tables";
            // 
            // buttonAllTables1
            // 
            this.buttonAllTables1.Location = new System.Drawing.Point(587, 254);
            this.buttonAllTables1.Name = "buttonAllTables1";
            this.buttonAllTables1.Size = new System.Drawing.Size(201, 23);
            this.buttonAllTables1.TabIndex = 11;
            this.buttonAllTables1.Text = "Alternative 1";
            this.buttonAllTables1.UseVisualStyleBackColor = true;
            this.buttonAllTables1.Click += new System.EventHandler(this.buttonAllTables1_Click);
            // 
            // buttonAllTables2
            // 
            this.buttonAllTables2.Location = new System.Drawing.Point(587, 294);
            this.buttonAllTables2.Name = "buttonAllTables2";
            this.buttonAllTables2.Size = new System.Drawing.Size(201, 23);
            this.buttonAllTables2.TabIndex = 12;
            this.buttonAllTables2.Text = "Alternative 2";
            this.buttonAllTables2.UseVisualStyleBackColor = true;
            this.buttonAllTables2.Click += new System.EventHandler(this.buttonAllTables2_Click);
            // 
            // labelEmployeeTables
            // 
            this.labelEmployeeTables.AutoSize = true;
            this.labelEmployeeTables.Location = new System.Drawing.Point(605, 333);
            this.labelEmployeeTables.Name = "labelEmployeeTables";
            this.labelEmployeeTables.Size = new System.Drawing.Size(183, 13);
            this.labelEmployeeTables.TabIndex = 13;
            this.labelEmployeeTables.Text = "Get all columns of the employee table";
            // 
            // buttonGetColumns1
            // 
            this.buttonGetColumns1.Location = new System.Drawing.Point(587, 360);
            this.buttonGetColumns1.Name = "buttonGetColumns1";
            this.buttonGetColumns1.Size = new System.Drawing.Size(201, 23);
            this.buttonGetColumns1.TabIndex = 14;
            this.buttonGetColumns1.Text = "Alternative 1";
            this.buttonGetColumns1.UseVisualStyleBackColor = true;
            this.buttonGetColumns1.Click += new System.EventHandler(this.buttonGetColumns1_Click);
            // 
            // buttonGetColumns2
            // 
            this.buttonGetColumns2.Location = new System.Drawing.Point(587, 402);
            this.buttonGetColumns2.Name = "buttonGetColumns2";
            this.buttonGetColumns2.Size = new System.Drawing.Size(201, 23);
            this.buttonGetColumns2.TabIndex = 15;
            this.buttonGetColumns2.Text = "Alternative 2";
            this.buttonGetColumns2.UseVisualStyleBackColor = true;
            this.buttonGetColumns2.Click += new System.EventHandler(this.buttonGetColumns2_Click);
            // 
            // errorMessageLbl
            // 
            this.errorMessageLbl.AutoSize = true;
            this.errorMessageLbl.Location = new System.Drawing.Point(313, 432);
            this.errorMessageLbl.Name = "errorMessageLbl";
            this.errorMessageLbl.Size = new System.Drawing.Size(0, 13);
            this.errorMessageLbl.TabIndex = 16;
            this.errorMessageLbl.Click += new System.EventHandler(this.errorMessageLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorMessageLbl);
            this.Controls.Add(this.buttonGetColumns2);
            this.Controls.Add(this.buttonGetColumns1);
            this.Controls.Add(this.labelEmployeeTables);
            this.Controls.Add(this.buttonAllTables2);
            this.Controls.Add(this.buttonAllTables1);
            this.Controls.Add(this.labelGetTables);
            this.Controls.Add(this.buttonAllConstraints);
            this.Controls.Add(this.buttonAllIndexes);
            this.Controls.Add(this.buttonAllKeys);
            this.Controls.Add(this.labelMetadata);
            this.Controls.Add(this.buttonEmployeeAbsentMost);
            this.Controls.Add(this.buttonEmployeeAbsent2004);
            this.Controls.Add(this.buttonEmployeeRelatives);
            this.Controls.Add(this.buttonEmployeeMetadata);
            this.Controls.Add(this.labelGetInformation);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelGetInformation;
        private System.Windows.Forms.Button buttonEmployeeMetadata;
        private System.Windows.Forms.Button buttonEmployeeRelatives;
        private System.Windows.Forms.Button buttonEmployeeAbsent2004;
        private System.Windows.Forms.Button buttonEmployeeAbsentMost;
        private System.Windows.Forms.Label labelMetadata;
        private System.Windows.Forms.Button buttonAllKeys;
        private System.Windows.Forms.Button buttonAllIndexes;
        private System.Windows.Forms.Button buttonAllConstraints;
        private System.Windows.Forms.Label labelGetTables;
        private System.Windows.Forms.Button buttonAllTables1;
        private System.Windows.Forms.Button buttonAllTables2;
        private System.Windows.Forms.Label labelEmployeeTables;
        private System.Windows.Forms.Button buttonGetColumns1;
        private System.Windows.Forms.Button buttonGetColumns2;
        private System.Windows.Forms.Label errorMessageLbl;
    }
}

