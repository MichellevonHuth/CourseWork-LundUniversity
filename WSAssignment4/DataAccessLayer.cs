using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSAssignment4
{
    public class DataAccessLayer
   {
        private static string connectionString = "User Id=IS12;Password=Grupp12.fmmi;Server=localhost;Database=DB_Grupp12";

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

        public List<SavingSchedule> GetAllSavingSchedules()
        {

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM SavingSchedule");
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<SavingSchedule> schedules = new List<SavingSchedule>();


            while (reader.Read())
            {

                string accountUsername = reader["accountUsername"].ToString();
                string totalIncome = reader["totalIncome"].ToString();
                string fixedCost = reader["fixedCost"].ToString();
                string variableCost = reader["variableCost"].ToString();
                string savingGoal = reader["savingGoal"].ToString();
                string savingDuration = reader["savingDuration"].ToString();

                SavingSchedule schedule1 = new SavingSchedule();
                schedule1.AccountUsername = accountUsername;
                schedule1.TotalIncome = totalIncome;
                schedule1.FixedCost = fixedCost;
                schedule1.VariableCost = variableCost;
                schedule1.SavingGoal = savingGoal;
                schedule1.SavingDuration = savingDuration;
                schedules.Add(schedule1);

            }

            return schedules;
        }

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

