using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSClient2_Assignment3
{
    public partial class Form1 : Form

    {
        private Assignment3ServiceReference.Assignment3ServiceSoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new Assignment3ServiceReference.Assignment3ServiceSoapClient();
        }

        private void getFileButton_Click(object sender, EventArgs e)
        {
            try
            {
              
                textBox.Text = client.TxtFile("C:\\Users\\Administrator\\Desktop\\HelloWorld.txt");
            }
            catch(Exception ex)
            {

            }
        }

       
    }
}
// denna följer MVC kolla föreläsningen om detta!!

