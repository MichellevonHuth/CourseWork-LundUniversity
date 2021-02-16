using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MyDesktopApp

{
    class DataAccessLayer
    { 
        private static string connectionString = "Integrated Security = True;server=localhost;Trusted_Connection=yes;Database=DB_Grupp12";
        
        public static int [] AddUser(string username, string name, string surename, int totalIncome, int fixedCost, int variableCost, int savingGoal, int savingDuration)
        {

            int[] createSchedule = CreateSchedule(totalIncome, fixedCost, variableCost, savingGoal, savingDuration);

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand= new SqlCommand("INSERT INTO Account VALUES(@username, @name, @surename)");
            sqlCommand.Parameters.AddWithValue("@table","Account");
            sqlCommand.Parameters.AddWithValue("@username",username);
            sqlCommand.Parameters.AddWithValue("@name",name);
            sqlCommand.Parameters.AddWithValue("@surename",surename);

            sqlCommand.Connection = sqlConnection;

            try 
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                
            }
            catch(SqlException ex)
            {
                ErrorHandler.HandleException(ex);
            }

            InsertIntoSaving(username, totalIncome, fixedCost, variableCost, savingGoal, savingDuration);

            return createSchedule;
        }


        public static void InsertIntoSaving(string username, int totalIncome, int fixedCost, int variableCost, int savingGoal, int savingDuration)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand1 = new SqlCommand("INSERT INTO SavingSchedule VALUES(@accountUsername, @totalIncome, @fixedCost, @variableCost, @savingGoal, @savingDuration)");
            sqlCommand1.Parameters.AddWithValue("@table", "SavingSchedule");
            sqlCommand1.Parameters.AddWithValue("@accountUsername", username);
            sqlCommand1.Parameters.AddWithValue("@totalIncome", totalIncome);
            sqlCommand1.Parameters.AddWithValue("@fixedCost", fixedCost);
            sqlCommand1.Parameters.AddWithValue("@variableCost", variableCost);
            sqlCommand1.Parameters.AddWithValue("@savingGoal", savingGoal);
            sqlCommand1.Parameters.AddWithValue("@savingDuration", savingDuration);

            sqlCommand1.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                sqlCommand1.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                ErrorHandler.HandleException(ex);
            }

        }

        public static int [] CreateSchedule(int totalIncome1, int fixedCost1, int variableCost1, int savingGoal1, int savingDuration1)
        {
            int x = fixedCost1 - variableCost1;
            int moneyLeft = totalIncome1 - x;
            int moneySaving = savingGoal1 / savingDuration1;

            int[] array = new int[3];

            if (moneySaving < moneyLeft)
            {

                array[2] = moneySaving;

            }

            else if (moneySaving > moneyLeft)
            {
                int howManyMonths = savingGoal1 / moneyLeft;

               
                array[0] = howManyMonths;
                array[1] = moneyLeft;
            }

            return array;

        }

        public static void DeleteSchedule(string username)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM SavingSchedule WHERE accountUsername"  + " = '" + username + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                ErrorHandler.HandleException(ex);
            }

    }

        public static void DeleteUser(string username)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Account WHERE username" + " = '" + username + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                ErrorHandler.HandleException(ex);
            }

        }

        public static void UpdateUser(string username, string name, string surename, int totalIncome, int fixedCost, int variableCost, int savingGoal, int savingDuration)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE Account SET name =@name, surename = @surename WHERE username = @username", con))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surename", surename);
                        command.ExecuteNonQuery();
                    }
                    con.Close();

                    con.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE SavingSchedule SET totalIncome=@totalIncome, fixedCost=@fixedCost, variableCost=@variableCost, savingGoal=@savingGoal, savingDuration=@savingDuration WHERE Accountusername = @username", con))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@totalIncome", totalIncome);
                        command.Parameters.AddWithValue("@fixedCost", fixedCost);
                        command.Parameters.AddWithValue("@variableCost", variableCost);
                        command.Parameters.AddWithValue("@savingGoal", savingGoal);
                        command.Parameters.AddWithValue("@savingDuration", savingDuration);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (SystemException ex)
            {
                ErrorHandler.HandleException(ex);
            }

        }

        public static int CheckIfUserExists(string username)
        {
            int userCount = 0; 
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) AS Count from Account where username=@username");
            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                userCount = reader.GetInt32(0);

            }

            return userCount; 
        }


        public static string [] FindUserAccounts(string username)
        {

            SqlConnection sqlConnection = new SqlConnection(connectionString);
           
            SqlCommand sqlCommand = new SqlCommand("SELECT username, name, surename, totalIncome, fixedCost, variableCost, savingGoal, savingDuration FROM Account JOIN SavingSchedule ON username = accountUsername WHERE username=@username ORDER BY username");

            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            string[] databaseValues = new string[8];

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                
                databaseValues[0] = reader["username"].ToString();
                databaseValues[1] = reader["name"].ToString();
                databaseValues[2] = reader["surename"].ToString();
                databaseValues[3] = reader["totalIncome"].ToString();
                databaseValues[4] = reader["fixedCost"].ToString();
                databaseValues[5] = reader["variableCost"].ToString();
                databaseValues[6] = reader["savingGoal"].ToString();
                databaseValues[7] = reader["savingDuration"].ToString();
                

            }

            return databaseValues; 
        }

    }

}
           
        
