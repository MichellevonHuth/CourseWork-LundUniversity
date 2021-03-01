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

        public List<string[]> MetaDataForEmployeeTable()
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.MetaDataForEmployeeTable(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    string[] rows = new string[8];
                    List<string[]> table = new List<string[]>();

                    while (reader.Read())
                    {

                        for (int i = 0; i < 50; i++)
                        {

                            rows[0] = reader["table_catalog"].ToString();
                            rows[1] = reader["table_name"].ToString();
                            rows[2] = reader["column_name"].ToString();
                            rows[3] = reader["ordinal_position"].ToString();
                            rows[4] = reader["is_nullable"].ToString();
                            rows[5] = reader["data_type"].ToString();
                            table.Add(rows);
                        }

                    }
                    return table;
                }


                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public List<string[]> EmployeeRelatives()
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.EmployeeRelatives(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    string[] rows = new string[5];
                    List<string[]> table = new List<string[]>();

                    while (reader.Read())
                    {

                        for (int i = 0; i < 12; i++)
                        {

                            rows[0] = reader["Employee No_"].ToString();
                            rows[1] = reader["Relative Code"].ToString();
                            rows[2] = reader["First Name"].ToString();
                            rows[3] = reader["Last Name"].ToString();
                            rows[4] = reader["Birth Date"].ToString();

                            table.Add(rows);
                        }

                    }
                    return table;
                }


                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public List<string[]> EmployeeAbsent2004()
        {
           

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.EmployeeAbsent2004(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    string[] rows = new string[1];
                    List<string[]> table = new List<string[]>();

                    while (reader.Read())
                    {

                        for (int i = 0; i < 7; i++)
                        {

                            rows[0] = reader["Employee_Number"].ToString();

                            table.Add(rows);
                        }

                    }
                    return table;
                }


                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }


        public List<string[]> EmployeeAbsentTheMost()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.EmployeeAbsentTheMost(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    string[] rows = new string[1];
                    List<string[]> table = new List<string[]>();

                    while (reader.Read())
                    {

                        for (int i = 0; i < 2; i++)
                        {
                            rows[0] = reader["First Name"].ToString();
                            table.Add(rows);
                        }

                    }
                    return table;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }


        public List<string[]> AllKeys()
        {
             using (SqlConnection sqlConnection = new SqlConnection(connectionString))
             {
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllKeys(), sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    string[] rows = new string[5];
                    List<string[]> table = new List<string[]>();

                    while (reader.Read())
                    {

                        for (int i = 0; i < 1000; i++)
                        {
                            rows[0] = reader["Column_name"].ToString();
                            rows[1] = reader["Constraint_name"].ToString();
                            rows[2] = reader["Key_type"].ToString();
                            rows[3] = reader["Type_desc"].ToString();
                            rows[4] = reader["Object_id"].ToString();
                            table.Add(rows);
                        }

                    }
                    return table;

                }

                catch (Exception ex)
                {
                    throw ex;
                }


             }

        }



            public List<string[]> AllIndexes()
            {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllIndexes(), sqlConnection);

                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        string[] rows = new string[3];
                        List<string[]> table = new List<string[]>();

                        while (reader.Read())
                        {

                            for (int i = 0; i < 1000; i++)
                            {
                                rows[0] = reader["object_id"].ToString();
                                rows[0] = reader["name"].ToString();
                                rows[0] = reader["index_id"].ToString();
                                table.Add(rows);
                            }

                        }
                        return table;
                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }

            }


            public List<string[]> AllTableConstraints()
            {
              
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllTableConstraints(), sqlConnection);

                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        string[] rows = new string[3];
                        List<string[]> table = new List<string[]>();

                        while (reader.Read())
                        {

                            for (int i = 0; i < 1000; i++)
                            {
                                rows[0] = reader["Table_Name"].ToString();
                                rows[1] = reader["Column_Name"].ToString();
                                rows[2] = reader["Constraint_Type"].ToString();

                            table.Add(rows);
                            }

                        }
                        return table;
                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }                                   

                }

            }

            

            public List<string[]> AllTables1()
            {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllTables1(), sqlConnection);

                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        string[] rows = new string[1];
                        List<string[]> table = new List<string[]>();

                        while (reader.Read())
                        {

                            for (int i = 0; i < 1000; i++)
                            {
                                rows[0] = reader["Tables"].ToString();

                                table.Add(rows);
                            }

                        }
                        return table;
                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }

            }

            }

            public List<string[]> AllTables2()
            {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllTables2(), sqlConnection);

                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        string[] rows = new string[1];
                        List<string[]> table = new List<string[]>();

                        while (reader.Read())
                        {

                            for (int i = 0; i < 1000; i++)
                            {
                                rows[0] = reader["Tables"].ToString();

                                table.Add(rows);
                            }

                        }
                        return table;
                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }

            }

            public List<string[]> AllColumns1()
            {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllColumns1(), sqlConnection);

                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        string[] rows = new string[1];
                        List<string[]> table = new List<string[]>();

                        while (reader.Read())
                        {

                            for (int i = 0; i < 45; i++)
                            {
                                rows[0] = reader["Columns"].ToString();

                                table.Add(rows);
                            }

                        }
                        return table;
                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }

            }

            public List<string[]> AllColumns2()
            {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(SqlQueries.AllColumns2(), sqlConnection);

                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        string[] rows = new string[1];
                        List<string[]> table = new List<string[]>();

                        while (reader.Read())
                        {

                            for (int i = 0; i < 45; i++)
                            {
                                rows[0] = reader["Columns"].ToString();

                                table.Add(rows);
                            }

                        }
                        return table;
                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }

            }

    }

}


