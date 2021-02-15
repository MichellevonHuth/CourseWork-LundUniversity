using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class DataAccessLayer
    {

        private static string connectionString = "Server=uwdb18.srv.lu.se\\icssql001;Database=SYSA14_PK_ProgAssignment2;User=sysa14reader; Password=INFreader1";
        private List<string> allcolumnName;
        private List<int> numberOfRow;


        public List<int> NumberOfRows()
        {
            List<int> numberOfRow = new List<int>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {

                            numberOfRow.Add(String.Format("0", dataReader[0]));
                        }
                    }
                }
                           
            }
            return numberOfRow();
        }

        public List<string> ColumnNames()
        {
            List<string> allColumnName = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {

                            allColumnName.Add(String.Format("0", dataReader[0]));

                        }
                    }
                }

            }
            return allcolumnName;
        }
    }
}

