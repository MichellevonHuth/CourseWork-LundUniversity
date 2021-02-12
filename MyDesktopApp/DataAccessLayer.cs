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
        private static string connectionString = "Integrated Security = True;server=localhost;Trusted_Connection=yes;Database=Grupp12_DB";
        
        public static int [] AddUser(string username, string name, string surename, int totalIncome, int fixedCost, int variableCost, int savingGoal, int durationAmount)
        {

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand= new SqlCommand("INSERT INTO Account VALUES(@username, @name, @surename)");
            sqlCommand.Parameters.AddWithValue("@table","Account");
            sqlCommand.Parameters.AddWithValue("@username",username);
            sqlCommand.Parameters.AddWithValue("@name",name);
            sqlCommand.Parameters.AddWithValue("@surename",surename);

            SqlCommand sqlCommand1= new SqlCommand("INSERT INTO SavingSchedule VALUES(@accountUsername,@totalIncome, @fixedCost, @variableCost, @savingGoal)");
            sqlCommand1.Parameters.AddWithValue("@table","SavingSchedule");
            sqlCommand1.Parameters.AddWithValue("@accountUsername",username);
            sqlCommand1.Parameters.AddWithValue("@totalIncome",totalIncome);
            sqlCommand1.Parameters.AddWithValue("@fixedCost",fixedCost);
            sqlCommand1.Parameters.AddWithValue("@variableCost",variableCost);
            sqlCommand1.Parameters.AddWithValue("@durationAmount",durationAmount);

            sqlCommand.Connection = sqlConnection;

            int []createSchedule = CreateSchedule(totalIncome, fixedCost, variableCost, savingGoal, durationAmount);

            try 
            {
                sqlConnection.Open();

                sqlCommand.EndExecuteNonQuery();

            }
            catch(SqlException ex)
            {
                ErrorHandler.HandleException(ex);
            }     
            return createSchedule;
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
           string query =  "DELETE FROM Account(username, name, surename) Values ('" + username + "','" + name + "','" + surename + "')";
           UpdateDB(query);
        }

        public void UpdateUser(String str)
        {


        }

     


        public void UpdateSchedule(int i)
        {

        }
        
       
        public static void UpdateDB(string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {

                        ErrorHandler.HandleException(ex);
                    }
                
            }

        }

    }

}
           
        
