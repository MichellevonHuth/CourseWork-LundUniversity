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

        public List<Account> GetAllAccounts()
        {

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Account");
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            List<Account> accounts = new List<Account>(); 
            
         

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {

                string username = reader["username"].ToString();
                string name = reader["name"].ToString();
                string surname = reader["surename"].ToString();

                Account account1 = new Account();
                account1.Name = name;
                account1.Username = username;
                account1.Surename = surname;
                accounts.Add(account1); 

            }

            return accounts;
        }

    }


   


}

