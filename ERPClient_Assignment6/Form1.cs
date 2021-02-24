using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPClient_Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEmployeeTables_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.MetaDataForEmployeeTable();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                this.dataGridView_SetText(message);
            }
        }

        private void buttonEmployeeRelative_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.EmployeeRelatives(); 
                messageDataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                this.MessageTextBox_SetText(message);
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
