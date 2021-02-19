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

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void getAllAccountsButton_Click(object sender, EventArgs e)
        {

            Account[] list = proxy.GetAccounts(); 

            foreach(Account a in list)
            {
                textBox.Text += ("Username: " + a.Username + " Name: " + a.Name + " Surname: " + a.Surename + "\r\n"); 
            }
            
        }
    }
}
