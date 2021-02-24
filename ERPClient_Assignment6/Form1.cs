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
        Assignment6Service proxy = new Assignment6Service();

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
                errorMessageLbl.Text = message;

            }
        }

        private void buttonEmployeeRelative_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.EmployeeRelatives();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void buttonEmployeeAbsent_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.EmployeeAbsent2004();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }
        }

        private void buttonEmployeeMostAbsent_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.EmployeeAbsentTheMost();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void buttonAllKeys_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllKeys();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void buttonAllIndexes_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllIndexes();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void buttonAllTablesConstraints_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllTableConstraints();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void buttonAllTables1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllTables1();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void buttonAllTables2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllTables2();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void buttonEmployeeColumns1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllColumns1();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void buttonEmployeeColumns2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = proxy.AllColumns2();
                dataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                string message = Errorhandler.HandleException(ex);
                errorMessageLbl.Text = message;
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void errorMessageLbl_Click(object sender, EventArgs e)
        {


        }
    }
}
