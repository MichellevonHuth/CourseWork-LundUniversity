using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSAssignment5
{
    public class DataAccessLayer
    {
        private static string connectionString = "User Id=IS12;Password=Grupp12.fmmi;Server=localhost;Database=CRONUS";

        public void CreateEmployee(string username, string name, string surename)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(""))
                {



                }
            }
        }

       

    }
}