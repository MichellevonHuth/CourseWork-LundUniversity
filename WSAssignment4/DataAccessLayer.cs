using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSAssignment4
{
        public class DataAccessLayer
        {
            private static string connectionString = "Integrated Security = True;server=localhost;Trusted_Connection=yes;Database=DB_Grupp12";

            public void InsertAccount(string username, string name, string surename)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Account VALUES(@username, @name, @surename)"))
                    {
                        sqlCommand.Parameters.AddWithValue("@username", username);
                        sqlCommand.Parameters.AddWithValue("@name", name);
                        sqlCommand.Parameters.AddWithValue("@surename", surename);

                        sqlCommand.Connection = sqlConnection;

                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();

                    }
                }
            }
        }



}

