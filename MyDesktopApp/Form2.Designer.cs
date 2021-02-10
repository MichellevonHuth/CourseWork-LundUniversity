namespace MyDesktopApp
{
    partial class Form2
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.PleaseFillInLabel = new System.Windows.Forms.Label();
            this.TotalIncome = new System.Windows.Forms.Label();
            this.TotalIncomeTextbox = new System.Windows.Forms.TextBox();
            this.FixedCosts = new System.Windows.Forms.Label();
            this.FixedCostsTextbox = new System.Windows.Forms.TextBox();
            this.VariableCosts = new System.Windows.Forms.Label();
            this.VariableCostsTextbox = new System.Windows.Forms.TextBox();
            this.SavingGoalsLabel = new System.Windows.Forms.Label();
            this.SavingGoalLabel = new System.Windows.Forms.Label();
            this.SavingGoalTextbox = new System.Windows.Forms.TextBox();
            this.SavingDuration = new System.Windows.Forms.Label();
            this.DurationComboBox = new System.Windows.Forms.ComboBox();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.Form2NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(82, 48);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(868, 45);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Your future schedule is ready in any second...";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // PleaseFillInLabel
            // 
            this.PleaseFillInLabel.AutoSize = true;
            this.PleaseFillInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PleaseFillInLabel.Location = new System.Drawing.Point(121, 153);
            this.PleaseFillInLabel.Name = "PleaseFillInLabel";
            this.PleaseFillInLabel.Size = new System.Drawing.Size(308, 25);
            this.PleaseFillInLabel.TabIndex = 1;
            this.PleaseFillInLabel.Text = "Please fill in information below:";
            this.PleaseFillInLabel.Click += new System.EventHandler(this.PleaseFillInLabel_Click);
            // 
            // TotalIncome
            // 
            this.TotalIncome.AutoSize = true;
            this.TotalIncome.Location = new System.Drawing.Point(121, 225);
            this.TotalIncome.Name = "TotalIncome";
            this.TotalIncome.Size = new System.Drawing.Size(186, 25);
            this.TotalIncome.TabIndex = 2;
            this.TotalIncome.Text = "Your total income:";
            this.TotalIncome.Click += new System.EventHandler(this.label3_Click);
            // 
            // TotalIncomeTextbox
            // 
            this.TotalIncomeTextbox.Location = new System.Drawing.Point(346, 225);
            this.TotalIncomeTextbox.Name = "TotalIncomeTextbox";
            this.TotalIncomeTextbox.Size = new System.Drawing.Size(100, 31);
            this.TotalIncomeTextbox.TabIndex = 3;
            this.TotalIncomeTextbox.TextChanged += new System.EventHandler(this.TotalIncomeTextbox_TextChanged);
            // 
            // FixedCosts
            // 
            this.FixedCosts.AutoSize = true;
            this.FixedCosts.Location = new System.Drawing.Point(121, 311);
            this.FixedCosts.Name = "FixedCosts";
            this.FixedCosts.Size = new System.Drawing.Size(173, 25);
            this.FixedCosts.TabIndex = 4;
            this.FixedCosts.Text = "Your fixed costs:";
            // 
            // FixedCostsTextbox
            // 
            this.FixedCostsTextbox.Location = new System.Drawing.Point(346, 308);
            this.FixedCostsTextbox.Name = "FixedCostsTextbox";
            this.FixedCostsTextbox.Size = new System.Drawing.Size(100, 31);
            this.FixedCostsTextbox.TabIndex = 5;
            this.FixedCostsTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // VariableCosts
            // 
            this.VariableCosts.AutoSize = true;
            this.VariableCosts.Location = new System.Drawing.Point(121, 402);
            this.VariableCosts.Name = "VariableCosts";
            this.VariableCosts.Size = new System.Drawing.Size(203, 25);
            this.VariableCosts.TabIndex = 6;
            this.VariableCosts.Text = "Your variable costs:";
            // 
            // VariableCostsTextbox
            // 
            this.VariableCostsTextbox.Location = new System.Drawing.Point(346, 396);
            this.VariableCostsTextbox.Name = "VariableCostsTextbox";
            this.VariableCostsTextbox.Size = new System.Drawing.Size(100, 31);
            this.VariableCostsTextbox.TabIndex = 7;
            this.VariableCostsTextbox.TextChanged += new System.EventHandler(this.VariableCostsTextbox_TextChanged);
            // 
            // SavingGoalsLabel
            // 
            this.SavingGoalsLabel.AutoSize = true;
            this.SavingGoalsLabel.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingGoalsLabel.Location = new System.Drawing.Point(121, 554);
            this.SavingGoalsLabel.Name = "SavingGoalsLabel";
            this.SavingGoalsLabel.Size = new System.Drawing.Size(264, 25);
            this.SavingGoalsLabel.TabIndex = 8;
            this.SavingGoalsLabel.Text = "Fill in your saving goals:";
            // 
            // SavingGoalLabel
            // 
            this.SavingGoalLabel.AutoSize = true;
            this.SavingGoalLabel.Location = new System.Drawing.Point(119, 625);
            this.SavingGoalLabel.Name = "SavingGoalLabel";
            this.SavingGoalLabel.Size = new System.Drawing.Size(180, 25);
            this.SavingGoalLabel.TabIndex = 9;
            this.SavingGoalLabel.Text = "Your saving goal:";
            // 
            // SavingGoalTextbox
            // 
            this.SavingGoalTextbox.Location = new System.Drawing.Point(346, 625);
            this.SavingGoalTextbox.Name = "SavingGoalTextbox";
            this.SavingGoalTextbox.Size = new System.Drawing.Size(100, 31);
            this.SavingGoalTextbox.TabIndex = 10;
            this.SavingGoalTextbox.TextChanged += new System.EventHandler(this.SavingGoalTextbox_TextChanged);
            // 
            // SavingDuration
            // 
            this.SavingDuration.AutoSize = true;
            this.SavingDuration.Location = new System.Drawing.Point(121, 703);
            this.SavingDuration.Name = "SavingDuration";
            this.SavingDuration.Size = new System.Drawing.Size(168, 25);
            this.SavingDuration.TabIndex = 11;
            this.SavingDuration.Text = "Saving duration:";
            // 
            // DurationComboBox
            // 
            this.DurationComboBox.FormattingEnabled = true;
            this.DurationComboBox.Location = new System.Drawing.Point(346, 703);
            this.DurationComboBox.Name = "DurationComboBox";
            this.DurationComboBox.Size = new System.Drawing.Size(121, 33);
            this.DurationComboBox.TabIndex = 12;
            this.DurationComboBox.SelectedIndexChanged += new System.EventHandler(this.DurationComboBox_SelectedIndexChanged);
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.Location = new System.Drawing.Point(346, 746);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(121, 31);
            this.AmountTextbox.TabIndex = 13;
            this.AmountTextbox.TextChanged += new System.EventHandler(this.AmountTextbox_TextChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(482, 753);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(73, 20);
            this.AmountLabel.TabIndex = 14;
            this.AmountLabel.Text = "(amount)";
            // 
            // Form2NextButton
            // 
            this.Form2NextButton.Location = new System.Drawing.Point(794, 796);
            this.Form2NextButton.Name = "Form2NextButton";
            this.Form2NextButton.Size = new System.Drawing.Size(156, 55);
            this.Form2NextButton.TabIndex = 15;
            this.Form2NextButton.Text = "Next";
            this.Form2NextButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 895);
            this.Controls.Add(this.Form2NextButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AmountTextbox);
            this.Controls.Add(this.DurationComboBox);
            this.Controls.Add(this.SavingDuration);
            this.Controls.Add(this.SavingGoalTextbox);
            this.Controls.Add(this.SavingGoalLabel);
            this.Controls.Add(this.SavingGoalsLabel);
            this.Controls.Add(this.VariableCostsTextbox);
            this.Controls.Add(this.VariableCosts);
            this.Controls.Add(this.FixedCostsTextbox);
            this.Controls.Add(this.FixedCosts);
            this.Controls.Add(this.TotalIncomeTextbox);
            this.Controls.Add(this.TotalIncome);
            this.Controls.Add(this.PleaseFillInLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label PleaseFillInLabel;
        private System.Windows.Forms.Label TotalIncome;
        private System.Windows.Forms.TextBox TotalIncomeTextbox;
        private System.Windows.Forms.Label FixedCosts;
        private System.Windows.Forms.TextBox FixedCostsTextbox;
        private System.Windows.Forms.Label VariableCosts;
        private System.Windows.Forms.TextBox VariableCostsTextbox;
        private System.Windows.Forms.Label SavingGoalsLabel;
        private System.Windows.Forms.Label SavingGoalLabel;
        private System.Windows.Forms.TextBox SavingGoalTextbox;
        private System.Windows.Forms.Label SavingDuration;
        private System.Windows.Forms.ComboBox DurationComboBox;
        private System.Windows.Forms.TextBox AmountTextbox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button Form2NextButton;
    }
}