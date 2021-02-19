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
        private Assignment4ServiceReference.Assignment4ServiceSoapClient client;

        public Form1()
        {
            InitializeComponent();
            client = new Assignment4ServiceReference.Assignment4ServiceSoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void getAllAccountsButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
