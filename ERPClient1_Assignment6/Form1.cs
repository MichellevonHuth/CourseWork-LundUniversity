using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPClient1_Assignment6
{
    public partial class Form1 : Form
    {
        Assignment6Service proxy = new Assignment6Service();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAllKeys_Click(object sender, EventArgs e)
        {


        }

        private void buttonAllIndexes_Click(object sender, EventArgs e)
        {

        }

        private void buttonAllConstraints_Click(object sender, EventArgs e)
        {

        }

        private void buttonAllTables1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAllTables2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetColumns1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetColumns2_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmployeeMetadata_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable dt = proxy.MetaDataForEmployeeTable();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;

            }

        }

        private void buttonEmployeeRelatives_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmployeeAbsent2004_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmployeeAbsentMost_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelGetInformation_Click(object sender, EventArgs e)
        {

        }

        private void labelMetadata_Click(object sender, EventArgs e)
        {

        }

        private void errorMessageLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
