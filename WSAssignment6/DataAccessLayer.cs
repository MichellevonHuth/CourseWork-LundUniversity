using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSAssignment6
{
    public class DataAccessLayer
    {
        private static string connectionString = "User Id=IS12;Password=Grupp12.fmmi;Server=localhost;Database=CRONUS";

        public DataTable MetaDataForEmployeeTable()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.MetaDataForEmployeeTable(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public DataTable EmployeeRelatives()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.EmployeeRelatives(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public DataTable EmployeeAbsent2004()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.EmployeeAbsent2004(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }



        public DataTable EmployeeAbsentTheMost()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.EmployeeAbsentTheMost(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }


        public DataTable AllKeys()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllKeys(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public DataTable AllIndexes()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllIndexes(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }


        public DataTable AllTableConstraints()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllTableConstraints(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public DataTable AllTables1()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllTables1(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public DataTable AllTables2()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllTables2(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public DataTable AllColumns1()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllColumns1(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public DataTable AllColumns2()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllColumns2(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    datatable.Load(dataReader);
                    return datatable;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }



    }
}