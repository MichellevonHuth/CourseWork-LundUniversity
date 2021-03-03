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
        Assignment3Service proxy = new Assignment3Service();

        public Form1()
        {
            InitializeComponent();
          
        }

        private void getFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = proxy.TxtFile("C:\\Users\\Administrator\\Desktop\\HelloWorld.txt");
            }
            catch(Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
// denna följer MVC kolla föreläsningen om detta!!

