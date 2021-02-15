using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataAccessLayer dal = new DataAccessLayer();

        //public DataAccessLayer Dal
        //{
        //    get => dal;
        //    set => dal = value;
        //}

        private void AllColumnName_btn_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = dal.ColumnNames();
                messageDataGridView.DataSource = dt;
            }
            catch(Exception ex)
            {
                Errorhandler.HandleException(ex);
            }
        }

        private void NumberOfRows_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dal.NumberOfRows();
                messageDataGridView.DataSource = dt;
            }

            catch (Exception ex)
            {
                Errorhandler.HandleException(ex);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
