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
        
        public static int [] AddUser(string username, string name, string surename, int totalIncome, int fixedCost, int variableCost, int savingGoal, int durationAmount)
        {

            int[] createSchedule = CreateSchedule(totalIncome, fixedCost, variableCost, savingGoal, durationAmount);

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

            InsertIntoSaving(username, totalIncome, fixedCost, variableCost, savingGoal, durationAmount);

            return createSchedule;
        }


        public static void InsertIntoSaving(string username, int totalIncome, int fixedCost, int variableCost, int savingGoal, int durationAmount)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand1 = new SqlCommand("INSERT INTO SavingSchedule VALUES(@accountUsername, @totalIncome, @fixedCost, @variableCost, @savingGoal, @savingDuration)");
            sqlCommand1.Parameters.AddWithValue("@table", "SavingSchedule");
            sqlCommand1.Parameters.AddWithValue("@accountUsername", username);
            sqlCommand1.Parameters.AddWithValue("@totalIncome", totalIncome);
            sqlCommand1.Parameters.AddWithValue("@fixedCost", fixedCost);
            sqlCommand1.Parameters.AddWithValue("@variableCost", variableCost);
            sqlCommand1.Parameters.AddWithValue("@savingGoal", savingGoal);
            sqlCommand1.Parameters.AddWithValue("@savingDuration", durationAmount);

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

        public static int [] CreateSchedule(int totalIncome1, int fixedCost1, int variableCost1, int savingGoal1, int durationAmount1)
        {
            int x = fixedCost1 - variableCost1;
            int moneyLeft = totalIncome1 - x;
            int moneySaving = savingGoal1 / durationAmount1;

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

        public void DeleteUser(string username, string name, string surename)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Account VALUES(@username, @name, @surename)");
            sqlCommand.Parameters.AddWithValue("@table", "Account");
            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@surename", surename);

            try
            {
                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                ErrorHandler.HandleException(ex);
            }

        }


        public static string FindAllUserAccounts(string username)
        {
            string getUsername = ""; 

            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Account WHERE username='" + username +"'"))
                {
                    try
                    {
                        sqlConnection.Open();

                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                               getUsername = String.Format("{0}", dataReader[0]);
                              
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        ErrorHandler.HandleException(ex);
                    }
                }
            }
           
            return getUsername; 
        }

        public void UpdateUser(String str)
        {


        }

        public void UpdateSchedule(int i)
        {

        }
    }

}
           
        
