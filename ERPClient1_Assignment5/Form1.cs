using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPClient1_Assignment5
{
    public partial class Form1 : Form
    {
        Assignment5Reference.Assignment5ServiceSoapClient proxy = new Assignment5Reference.Assignment5ServiceSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            if (textBoxNo_.Text == "" || textBoxName.Text == "" || textBoxLastName.Text == "" || textBoxJobTitle.Text == "" )

            {
                MessageBox.Show(ErrorHandler.ErrorMessageEmptyFields());
            }

            else
            {
                string no_ = textBoxNo_.Text;
                string firstName = textBoxName.Text;
                string lastName = textBoxLastName.Text;
                string jobTitle = textBoxJobTitle.Text;

                bool ifExists = proxy.CreateEmployee(no_, firstName, lastName, jobTitle);

                if(ifExists == true)
                {
                    OutputTextBox.Text = no_ + " is now added in the database!";
                }

                else
                {
                    MessageBox.Show(ErrorHandler.Exists(no_));
                }
               
                textBoxJobTitle.Clear();
                textBoxLastName.Clear();
                textBoxName.Clear();
                textBoxNo_.Clear();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (textBoxNo_.Text == "" || textBoxName.Text == "" || textBoxLastName.Text == "" || textBoxJobTitle.Text == "")

            {
                MessageBox.Show(ErrorHandler.ErrorMessageEmptyFields());
            }

            else
            {
                string no_ = textBoxNo_.Text;
                string firstName = textBoxName.Text;
                string lastName = textBoxLastName.Text;
                string jobTitle = textBoxJobTitle.Text;

                bool ifExists = proxy.UpdateEmployee(no_, firstName, lastName, jobTitle);

                if (ifExists == true)
                {
                    OutputTextBox.Text = no_ + " just got updated in the database!";
                }

                else
                {
                    MessageBox.Show(ErrorHandler.DoesNotExists(no_));
                }

                textBoxJobTitle.Clear();
                textBoxLastName.Clear();
                textBoxName.Clear();
                textBoxNo_.Clear();
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (textBoxNo_.Text == "")

            {
                MessageBox.Show("Please fill in the employee number!"); 

            }

            else
            {
                
                string no_ = textBoxNo_.Text;
                bool ifExists = proxy.DeleteEmployee(no_);

                if (ifExists == true)
                {
                    OutputTextBox.Text = no_ + " just got deleted from the database!";
                }

                else
                {
                    MessageBox.Show(ErrorHandler.DoesNotExists(no_));
                }
            
                textBoxJobTitle.Clear();
                textBoxLastName.Clear();
                textBoxName.Clear();
                textBoxNo_.Clear();

            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
           List<string> allEmployees = proxy.ReadEmployees();
           string message = "";

            {   
                foreach(string a in allEmployees)

                {
                    message += a;
                    message += "\r\n"; 
                }

                OutputTextBox.Text = message;
            }
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNo__TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxJobTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNo__Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void labelJobTitle_Click(object sender, EventArgs e)
        {

        }

    }
}
