using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {

        private DataAccessLayer dal;
        private Form1 form;

        public DataAccessLayer Dal 
        {
            get => dal;
            set => dal = value;
        }
        public Form1 Form
        {
            get => form;
            set => form = value;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void nbrOfRows_Btn_Click(object sender, EventArgs e)
        {

        }

     

        private void message_txtB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void allColumnNames_Btn_Click(object sender, EventArgs e)
        {

            List<string> list = dal.ColumnNames();
            string allColumnNames;

            foreach (string i in list)
            {
                form.message_txtB.AppendText(i);
            }

            

        }
    }
}
