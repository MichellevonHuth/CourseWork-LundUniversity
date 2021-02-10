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

        
        public static void AddUser(String str)
        {

        }

        public static void DeleteUser(String str)
        {

        }

        public static void UpdateUser(String str)
        {
            

        }

        public static int CreateSchedule(int i)
        {
            return 0;
        }

        public static void UpdateSchedule(int i)
        {
            
        }

        public static string CallOnDB (object x)
        {

            string returnString; 

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * users FROM Users", sqlConnection))

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

                    catch(SqlExecption ex)
                    {
                        ErrorHandler(ex); 
                    }

                    finally
                    {
                        sqlConnection.Close();
                    }
                }   
            }

            return returnString;

        }
    }
    
}
