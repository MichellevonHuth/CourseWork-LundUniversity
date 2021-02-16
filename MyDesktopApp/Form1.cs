using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyDesktopApp.DataAccessLayer;
using System.Windows.Forms;

namespace MyDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
      
            try
            {
                if (UsernameTextbox.Text == "" || NameTextbox.Text == "" || SurenameTextbox.Text == "" || TotalIncomeTextbox.Text == "" || FixedCostTextbox.Text == "" || VariableCostsTextbox.Text == "" || SavingGoalTextbox.Text == "" || AmountTextbox.Text == "" )
                {

                    MessageBox.Show("Please fill all the fields");
                }

                else
                {
                  
                    string username = UsernameTextbox.Text;
                    string name = NameTextbox.Text;
                    string surename = SurenameTextbox.Text;

                    int totalIncome = Int32.Parse(TotalIncomeTextbox.Text);
                    int fixedCost = Int32.Parse(FixedCostTextbox.Text);
                    int variableCost = Int32.Parse(VariableCostsTextbox.Text);
                    int savingGoal = Int32.Parse(SavingGoalTextbox.Text);
                    int savingDuration = Int32.Parse(AmountTextbox.Text);

                    int [] createSchedule = DataAccessLayer.AddUser(username, name, surename, totalIncome, fixedCost, variableCost, savingGoal, savingDuration);

                    if (createSchedule[2] == 0)
                    {

                        outputBOX.Text = "Username: " + username + "\r\n Name: " + name + "\r\n Surename:" + surename + "\r\n\r\n Your saving goal is not possible within the timeframe you decided. To make this work, you need to save " + createSchedule[1] + "kr every month for " + createSchedule[0] + " months."; 
                    }

                    else
                    {

                        outputBOX.Text = "Username: " + username + "\r\n Name: " + name + "\r\n Surename:" + surename + "\r\n\r\n You need to save " + createSchedule[2] + "kr every month for " + savingDuration + " months to achieve your saving goal: " + savingGoal + "kr.";
                    }              
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleException(ex);
            }
        }


        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = FindTextbox.Text;
                int chechIfUserExists = DataAccessLayer.CheckIfUserExists(username);

                if (FindTextbox.Text == "")
                {
                    MessageBox.Show("Please fill in your username");
                }

                else if (chechIfUserExists == 1)
                {
                    
                    string[] databaseValues = DataAccessLayer.FindUserAccounts(username);
                    outputBOX.Text = "Username: " + databaseValues[0] + "\r\nName: " + databaseValues[1] + "\r\n Surename: " + databaseValues[2] + "\r\n\r\nTotal income: " + databaseValues[3] + "\r\n Fixed costs: " + databaseValues[4] + "\r\n Variable costs: " + databaseValues[5] + "\r\n Saving goal: " + databaseValues[6] + "\r\n Saving duration: " + databaseValues[7];
                }

                else
                {

                    outputBOX.Text = username + " is not registred in the database.";
                }

            }

            catch (Exception ex)
            {
                ErrorHandler.HandleException(ex);
            }
        }  

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string username = FindTextbox.Text;

            int chechIfUserExists = DataAccessLayer.CheckIfUserExists(username); 

            if(chechIfUserExists == 1)
            {
                DataAccessLayer.DeleteSchedule(username);
                DataAccessLayer.DeleteUser(username);

                string[] findUser = DataAccessLayer.FindUserAccounts(username);

                if (findUser[0] == null)
                {
                    outputBOX.Text = username + " is deleted!";
                }

            }
            else
            {
                outputBOX.Text = username + " is not registred in the database.";
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTextbox.Text == "" || NameTextbox.Text == "" || SurenameTextbox.Text == "" || TotalIncomeTextbox.Text == "" || FixedCostTextbox.Text == "" || VariableCostsTextbox.Text == "" || SavingGoalTextbox.Text == "" || AmountTextbox.Text == "")
                {

                    MessageBox.Show("Please fill all the fields");
                }

                else
                {
                    string username = UsernameTextbox.Text;
                    string name = NameTextbox.Text;
                    string surename = SurenameTextbox.Text;

                    int totalIncome = Int32.Parse(TotalIncomeTextbox.Text);
                    int fixedCost = Int32.Parse(FixedCostTextbox.Text);
                    int variableCost = Int32.Parse(VariableCostsTextbox.Text);
                    int savingGoal = Int32.Parse(SavingGoalTextbox.Text);
                    int savingDuration = Int32.Parse(AmountTextbox.Text);

                    int chechIfUserExists = DataAccessLayer.CheckIfUserExists(username);
                    
                    if(chechIfUserExists == 1)
                    {
                        DataAccessLayer.UpdateUser(username, name, surename, totalIncome, fixedCost, variableCost, savingGoal, savingDuration);

                        int[] createSchedule = DataAccessLayer.AddUser(username, name, surename, totalIncome, fixedCost, variableCost, savingGoal, savingDuration);

                        if (createSchedule[2] == 0)
                        {

                            outputBOX.Text = "THIS IS YOUR UPDATED SCHEDULE " + "\r\n\r\nUsername: " + username + "\r\n Name: " + name + "\r\n Surename:" + surename + "\r\n\r\n Your saving goal is not possible within the timeframe you decided. To make this work, you need to save " + createSchedule[1] + "kr every month for " + createSchedule[0] + " months.";
                        }

                        else
                        {

                            outputBOX.Text = "THIS IS YOUR UPDATED SCHEDULE " + "\r\n\r\nUsername: " + username + "\r\n Name: " + name + "\r\n Surename:" + surename + "\r\n\r\n You need to save " + createSchedule[2] + "kr every month for " + savingDuration + " months to achieve your saving goal: " + savingGoal + "kr.";
                        }
                    }

                    else
                    {
                        outputBOX.Text = username + " is not registred in the database.";
                    }
                }
            }

            catch (Exception ex)
            {
                ErrorHandler.HandleException(ex);
            }
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(NameTextbox.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
             
            }

        }

        private void SurenameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(SurenameTextbox.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
            }

        }

        private void FixedCostTextbox_TextChanged(object sender, EventArgs e)
        {
            int outParse;

            if (!Int32.TryParse(FixedCostTextbox.Text, out outParse))
            {
                MessageBox.Show("This textbox accepts only numbers");
            }

        }

        private void TotalIncomeTextbox_TextChanged(object sender, EventArgs e)
        {
            int outParse;
           
            if (!Int32.TryParse(TotalIncomeTextbox.Text, out outParse))
            {
                MessageBox.Show("This textbox accepts only numbers");
            }

        }

        private void VariableCostsTextbox_TextChanged(object sender, EventArgs e)
        {
            int outParse;

            if (!Int32.TryParse(VariableCostsTextbox.Text, out outParse))
            {
                MessageBox.Show("This textbox accepts only numbers");
            }
        }

        private void SavingGoalTextbox_TextChanged(object sender, EventArgs e)
        {
            int outParse;

            if (!Int32.TryParse(SavingGoalTextbox.Text, out outParse))
            {
                MessageBox.Show("This textbox accepts only numbers");
            }

        }

        private void AmountTextbox_TextChanged(object sender, EventArgs e)
        {
            int outParse;

            if (!Int32.TryParse(AmountTextbox.Text, out outParse))
            {
                MessageBox.Show("This textbox accepts only numbers");
            }

        }


        private void FixedCosts_Click(object sender, EventArgs e)
        {

        }

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void PleaseFillInLabel_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }



        private void NameLabel_Click(object sender, EventArgs e)
        {

        }


        private void SureNameLabel_Click(object sender, EventArgs e)
        {

        }



        private void VariableCosts_Click(object sender, EventArgs e)
        {

        }

        private void SavingGoalsLabel_Click(object sender, EventArgs e)
        {

        }

        private void SavingGoalLabel_Click(object sender, EventArgs e)
        {

        }

        private void SavingDuration_Click(object sender, EventArgs e)
        {

        }

        private void AmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FindTextbox_TextChanged(object sender, EventArgs e)
        {

            FindTextbox.Text = "Username...";

            if (FindTextbox.Text == "Username...")
            {
                FindTextbox.Text = "";
            }

            else if (FindTextbox.Text == "")
            {
                FindTextbox.Text = "Username...";
            }


        }


      private void outputBOX_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
