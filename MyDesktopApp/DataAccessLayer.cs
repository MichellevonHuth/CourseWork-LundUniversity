using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ErrorHandler; 

namespace MyDesktopApp

{
    class DataAccessLayer
    {
        private string connectionString = "Server=localhost;Database=DB_Grupp12;User=IS12; Password=Grupp12.fmmi!";

        public void AddUser(string username, string name, string surename, string accountUsername, int totalIncome, int fixedCost, int variableCost, int savingGoal, int savingDuration)
        {
            string query1 = "INSERT INTO Account(username, name, surename) Values ('" + username + "','" + name + "','" + surename + "')";
            string query2 = "INSERT INTO SavingSchedule(accountUsername, totalIncome, fixedCost, variableCost,savingGoal, savingDuration) Values ('" + accountUsername + "','" + totalIncome + "','" + fixedCost + "','" + variableCost + "','" + savingGoal + "','" + savingDuration + "')";
            CallOnDB(query1);
            CallOnDB(query2);
        }

        public void DeleteUser(String str)
        {


        }

        public void UpdateUser(String str)
        {
            

        }

        public int CreateSchedule(int i)
        {
            return 0;
        }

        public void UpdateSchedule(int i)
        {
            
        }

        public void CallOnDB (object x)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(x, sqlConnection))

                {
                    try
                    {
                        sqlConnection.Open();

                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            while(dataReader.Read())
                            {

                                returnString = (String.Format("{0}", dataReader[0]));
                            }

                            dataReader.Close();
                        }
                    }

                    catch(Execption ex)
                    {
                        Console.WriteLine(ErrorHandler(ex)); 
                    }

                    finally
                    {
                        sqlConnection.Close();
                    }
            
                }   
            }

        }
    }
    
}
