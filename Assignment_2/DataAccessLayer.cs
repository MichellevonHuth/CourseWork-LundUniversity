using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public class DataAccessLayer
    {
        Errorhandler errorHandler = new Errorhandler();

        private static string connectionString = "Server=uwdb18.srv.lu.se\\icssql001;Database=SYSA14_PK_ProgAssignment2;User=sysa14reader; Password=INFreader1";

        public List<string> ColumnNames()
        {

            List<string> columnNames = new List<string>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand("SELECT tableName FROM TablesOfInterest", sqlConnection))
                {
                    try
                    {

                        sqlConnection.Open();

                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        List<string> list = new List<string>();

                        while (dataReader.Read())
                        {
                            list.Add(dataReader["tableName"].ToString());

                        }

                        sqlConnection.Close();
                        columnNames = GetColumns(list);

                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return columnNames;
        }

        public List<string> GetColumns(List<string> list)
        {
            List<string> columnNames = new List<string>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                foreach (string a in list)
                {
                    SqlCommand sqlCommand1 = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + a + "'", sqlConnection);


                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader dataReader = sqlCommand1.ExecuteReader();

                        while (dataReader.Read())
                        {
                            columnNames.Add(dataReader["COLUMN_NAME"].ToString());

                        }

                        sqlConnection.Close();

                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }

                return columnNames;
            }

        }

        public List<string> GetTables()
        {

            List<string> numberOfRows = new List<string>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand("SELECT tableName FROM TablesOfInterest", sqlConnection))
                {
                    try
                    {

                        sqlConnection.Open();

                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        List<string> list = new List<string>();

                        while (dataReader.Read())
                        {
                            list.Add(dataReader["tableName"].ToString());

                        }

                        sqlConnection.Close();
                        numberOfRows = GetNumberOfRows(list);

                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }


            }

            return numberOfRows;

        }

        public List<string> GetNumberOfRows(List<string> list)
        {
            List<string> numberOfRows = new List<string>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                foreach (string a in list)
                {
                    SqlCommand sqlCommand1 = new SqlCommand("SELECT COUNT(*) as NbrOfRows FROM " + a, sqlConnection);


                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader dataReader = sqlCommand1.ExecuteReader();

                        while (dataReader.Read())
                        {

                            string row = a +": "+ dataReader["NbrOfRows"].ToString();
                            numberOfRows.Add(row);

                        }

                        sqlConnection.Close();

                    }

                    catch (Exception ex)
                    {
                       throw ex;
                    }

                }

                return numberOfRows;
            }

        }



    }

    }

      
