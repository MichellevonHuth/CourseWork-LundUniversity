using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSClient2_Assignment4
{
    public partial class Form1 : Form
    {
        Assignment4Service proxy = new Assignment4Service();
        Errorhandler errorhandler = new Errorhandler();

        public Form1()
        {
            InitializeComponent();
                  
        }


        private void getAllAccountsButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            errorMessageLbl.Text = "";

            try
            {
                Account[] list = proxy.GetAccounts();

                foreach (Account a in list)
                {
                    textBox.Text += ("Username: " + a.Username + " Name: " + a.Name + " Surname: " + a.Surename + "\r\n");
                }
            }
            catch(Exception ex)
            {
                string message = errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;

            }
            
        }

        private void getAllSchedulesButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            errorMessageLbl.Text = "";

            try
            {
                SavingSchedule[] list = proxy.GetSavingSchedules();

                foreach (SavingSchedule a in list)
                {
                    textBox.Text += ("Username: " + a.AccountUsername + " Total Income: " + a.TotalIncome + " Fixed Cost: " + a.FixedCost + " Variable Cost: " + a.VariableCost + " Saving Goal: " + a.SavingGoal + " Saving Duration: " + a.SavingDuration + "\r\n");
                }
            }

            catch (Exception ex)
            {
                string message = errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;

            }
        }
    }
}
