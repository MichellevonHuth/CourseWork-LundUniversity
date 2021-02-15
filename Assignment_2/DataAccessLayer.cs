using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class DataAccessLayer
    {

        private static string connectionString = "Server=uwdb18.srv.lu.se\\icssql001;Database=SYSA14_PK_ProgAssignment2;User=sysa14reader; Password=INFreader1";
        private List<string> allcolumnName;
        private List<string> numberOfRow;


        public DataTable ColumnNames()
        {
            DataTable datatable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                SqlCommand sqlCommand = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'TablesOfInterest'", sqlConnection);
                
                    
                sqlConnection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                datatable.Load(dataReader);
                return datatable;
                    
                

            }
            
        }

        public DataTable NumberOfRows()
        {
            DataTable datatable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT (*) AS NumberOfRows FROM dbo.TablesOfInterest", sqlConnection);


                sqlConnection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                datatable.Load(dataReader);
                return datatable;



            }

        }
    }
}
