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
        Assignment5Service proxy = new Assignment5Service();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {


            if (textBoxJobTitle.Text == "" || textBoxName.Text == "" || textBoxLastName.Text == "" || textBoxJobTitle.Text == "" )

            {

                OutputTextBox.Text = "Please fill all the fields";
            }
            else
            {
                string no_ = textBoxNo_.Text;
                string firstName = textBoxName.Text;
                string lastName = textBoxLastName.Text;
                string jobTitle = textBoxJobTitle.Text;

                OutputTextBox.Text = proxy.CreateEmployee(no_, firstName, lastName, jobTitle);
            }

            textBoxJobTitle.Clear();
            textBoxLastName.Clear();
            textBoxName.Clear();
            textBoxNo_.Clear();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            textBoxJobTitle.Clear();
            textBoxLastName.Clear();
            textBoxName.Clear();
            textBoxNo_.Clear();


            string no_ = textBoxNo_.Text;
            string firstName = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            string jobTitle = textBoxJobTitle.Text;

            proxy.UpdateEmployee(no_, firstName, lastName, jobTitle);

            OutputTextBox.Text = no_ + "just got updated!";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxJobTitle.Clear();
            textBoxLastName.Clear();
            textBoxName.Clear();
            textBoxNo_.Clear();

            string no_ = textBoxNo_.Text;
            proxy.DeleteEmployee(no_);

            OutputTextBox.Text = no_ + "just got deleted!";
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            string[] allEmployees = proxy.ReadEmployees();

            foreach (string a in allEmployees)
            {
                OutputTextBox.Text = "No_:" + a + "First Name: " + a + "Last Name: " + a + "Job Title: " + a + "\r\n";
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
