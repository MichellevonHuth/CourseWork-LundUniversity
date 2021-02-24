namespace ERPClient_Assignment6
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
            this.buttonEmployeeTables = new System.Windows.Forms.Button();
            this.buttonEmployeeRelative = new System.Windows.Forms.Button();
            this.buttonEmployeeAbsent = new System.Windows.Forms.Button();
            this.buttonEmployeeMostAbsent = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.labelGetMetaData = new System.Windows.Forms.Label();
            this.buttonAllKeys = new System.Windows.Forms.Button();
            this.buttonAllIndexes = new System.Windows.Forms.Button();
            this.buttonAllTablesConstraints = new System.Windows.Forms.Button();
            this.labelAllTables = new System.Windows.Forms.Label();
            this.buttonAllTables1 = new System.Windows.Forms.Button();
            this.buttonAllTables2 = new System.Windows.Forms.Button();
            this.labelEmployeeColumns = new System.Windows.Forms.Label();
            this.buttonEmployeeColumns1 = new System.Windows.Forms.Button();
            this.buttonEmployeeColumns2 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEmployeeTables
            // 
            this.buttonEmployeeTables.Location = new System.Drawing.Point(16, 150);
            this.buttonEmployeeTables.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEmployeeTables.Name = "buttonEmployeeTables";
            this.buttonEmployeeTables.Size = new System.Drawing.Size(418, 44);
            this.buttonEmployeeTables.TabIndex = 1;
            this.buttonEmployeeTables.Text = "Employee tables";
            this.buttonEmployeeTables.UseVisualStyleBackColor = true;
            this.buttonEmployeeTables.Click += new System.EventHandler(this.buttonEmployeeTables_Click);
            // 
            // buttonEmployeeRelative
            // 
            this.buttonEmployeeRelative.Location = new System.Drawing.Point(16, 287);
            this.buttonEmployeeRelative.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEmployeeRelative.Name = "buttonEmployeeRelative";
            this.buttonEmployeeRelative.Size = new System.Drawing.Size(418, 44);
            this.buttonEmployeeRelative.TabIndex = 2;
            this.buttonEmployeeRelative.Text = "Employees relatives";
            this.buttonEmployeeRelative.UseVisualStyleBackColor = true;
            this.buttonEmployeeRelative.Click += new System.EventHandler(this.buttonEmployeeRelative_Click);
            // 
            // buttonEmployeeAbsent
            // 
            this.buttonEmployeeAbsent.Location = new System.Drawing.Point(16, 408);
            this.buttonEmployeeAbsent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEmployeeAbsent.Name = "buttonEmployeeAbsent";
            this.buttonEmployeeAbsent.Size = new System.Drawing.Size(418, 44);
            this.buttonEmployeeAbsent.TabIndex = 3;
            this.buttonEmployeeAbsent.Text = "Employee absent due to sickness";
            this.buttonEmployeeAbsent.UseVisualStyleBackColor = true;
            // 
            // buttonEmployeeMostAbsent
            // 
            this.buttonEmployeeMostAbsent.Location = new System.Drawing.Point(16, 552);
            this.buttonEmployeeMostAbsent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEmployeeMostAbsent.Name = "buttonEmployeeMostAbsent";
            this.buttonEmployeeMostAbsent.Size = new System.Drawing.Size(418, 44);
            this.buttonEmployeeMostAbsent.TabIndex = 4;
            this.buttonEmployeeMostAbsent.Text = "Most absent employee";
            this.buttonEmployeeMostAbsent.UseVisualStyleBackColor = true;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(114, 69);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(224, 25);
            this.labelInformation.TabIndex = 5;
            this.labelInformation.Text = "Get information about:";
            // 
            // labelGetMetaData
            // 
            this.labelGetMetaData.AutoSize = true;
            this.labelGetMetaData.Location = new System.Drawing.Point(1262, 69);
            this.labelGetMetaData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGetMetaData.Name = "labelGetMetaData";
            this.labelGetMetaData.Size = new System.Drawing.Size(207, 25);
            this.labelGetMetaData.TabIndex = 6;
            this.labelGetMetaData.Text = "Get metadata about:";
            // 
            // buttonAllKeys
            // 
            this.buttonAllKeys.Location = new System.Drawing.Point(1240, 119);
            this.buttonAllKeys.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAllKeys.Name = "buttonAllKeys";
            this.buttonAllKeys.Size = new System.Drawing.Size(266, 44);
            this.buttonAllKeys.TabIndex = 7;
            this.buttonAllKeys.Text = "All keys";
            this.buttonAllKeys.UseVisualStyleBackColor = true;
            // 
            // buttonAllIndexes
            // 
            this.buttonAllIndexes.Location = new System.Drawing.Point(1240, 175);
            this.buttonAllIndexes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAllIndexes.Name = "buttonAllIndexes";
            this.buttonAllIndexes.Size = new System.Drawing.Size(266, 44);
            this.buttonAllIndexes.TabIndex = 8;
            this.buttonAllIndexes.Text = "All indexes";
            this.buttonAllIndexes.UseVisualStyleBackColor = true;
            // 
            // buttonAllTablesConstraints
            // 
            this.buttonAllTablesConstraints.Location = new System.Drawing.Point(1240, 231);
            this.buttonAllTablesConstraints.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAllTablesConstraints.Name = "buttonAllTablesConstraints";
            this.buttonAllTablesConstraints.Size = new System.Drawing.Size(266, 44);
            this.buttonAllTablesConstraints.TabIndex = 9;
            this.buttonAllTablesConstraints.Text = "All tables constraint";
            this.buttonAllTablesConstraints.UseVisualStyleBackColor = true;
            // 
            // labelAllTables
            // 
            this.labelAllTables.AutoSize = true;
            this.labelAllTables.Location = new System.Drawing.Point(1294, 306);
            this.labelAllTables.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAllTables.Name = "labelAllTables";
            this.labelAllTables.Size = new System.Drawing.Size(144, 25);
            this.labelAllTables.TabIndex = 11;
            this.labelAllTables.Text = "Get all tables ";
            // 
            // buttonAllTables1
            // 
            this.buttonAllTables1.Location = new System.Drawing.Point(1254, 337);
            this.buttonAllTables1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAllTables1.Name = "buttonAllTables1";
            this.buttonAllTables1.Size = new System.Drawing.Size(216, 52);
            this.buttonAllTables1.TabIndex = 12;
            this.buttonAllTables1.Text = "Alternative 1";
            this.buttonAllTables1.UseVisualStyleBackColor = true;
            // 
            // buttonAllTables2
            // 
            this.buttonAllTables2.Location = new System.Drawing.Point(1254, 408);
            this.buttonAllTables2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAllTables2.Name = "buttonAllTables2";
            this.buttonAllTables2.Size = new System.Drawing.Size(216, 52);
            this.buttonAllTables2.TabIndex = 13;
            this.buttonAllTables2.Text = "Alternative 2";
            this.buttonAllTables2.UseVisualStyleBackColor = true;
            // 
            // labelEmployeeColumns
            // 
            this.labelEmployeeColumns.AutoSize = true;
            this.labelEmployeeColumns.Location = new System.Drawing.Point(1180, 539);
            this.labelEmployeeColumns.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeeColumns.Name = "labelEmployeeColumns";
            this.labelEmployeeColumns.Size = new System.Drawing.Size(383, 25);
            this.labelEmployeeColumns.TabIndex = 14;
            this.labelEmployeeColumns.Text = "Get all columns of the employee tables";
            // 
            // buttonEmployeeColumns1
            // 
            this.buttonEmployeeColumns1.Location = new System.Drawing.Point(1254, 588);
            this.buttonEmployeeColumns1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEmployeeColumns1.Name = "buttonEmployeeColumns1";
            this.buttonEmployeeColumns1.Size = new System.Drawing.Size(216, 52);
            this.buttonEmployeeColumns1.TabIndex = 15;
            this.buttonEmployeeColumns1.Text = "Alternative 1";
            this.buttonEmployeeColumns1.UseVisualStyleBackColor = true;
            // 
            // buttonEmployeeColumns2
            // 
            this.buttonEmployeeColumns2.Location = new System.Drawing.Point(1254, 652);
            this.buttonEmployeeColumns2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEmployeeColumns2.Name = "buttonEmployeeColumns2";
            this.buttonEmployeeColumns2.Size = new System.Drawing.Size(216, 52);
            this.buttonEmployeeColumns2.TabIndex = 16;
            this.buttonEmployeeColumns2.Text = "Alternative 2";
            this.buttonEmployeeColumns2.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(506, 69);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(636, 694);
            this.dataGridView.TabIndex = 17;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonEmployeeColumns2);
            this.Controls.Add(this.buttonEmployeeColumns1);
            this.Controls.Add(this.labelEmployeeColumns);
            this.Controls.Add(this.buttonAllTables2);
            this.Controls.Add(this.buttonAllTables1);
            this.Controls.Add(this.labelAllTables);
            this.Controls.Add(this.buttonAllTablesConstraints);
            this.Controls.Add(this.buttonAllIndexes);
            this.Controls.Add(this.buttonAllKeys);
            this.Controls.Add(this.labelGetMetaData);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.buttonEmployeeMostAbsent);
            this.Controls.Add(this.buttonEmployeeAbsent);
            this.Controls.Add(this.buttonEmployeeRelative);
            this.Controls.Add(this.buttonEmployeeTables);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEmployeeTables;
        private System.Windows.Forms.Button buttonEmployeeRelative;
        private System.Windows.Forms.Button buttonEmployeeAbsent;
        private System.Windows.Forms.Button buttonEmployeeMostAbsent;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label labelGetMetaData;
        private System.Windows.Forms.Button buttonAllKeys;
        private System.Windows.Forms.Button buttonAllIndexes;
        private System.Windows.Forms.Button buttonAllTablesConstraints;
        private System.Windows.Forms.Label labelAllTables;
        private System.Windows.Forms.Button buttonAllTables1;
        private System.Windows.Forms.Button buttonAllTables2;
        private System.Windows.Forms.Label labelEmployeeColumns;
        private System.Windows.Forms.Button buttonEmployeeColumns1;
        private System.Windows.Forms.Button buttonEmployeeColumns2;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

