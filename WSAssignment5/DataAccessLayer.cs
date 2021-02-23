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

        public void CreateEmployee(string no_, string firstName, string lastName, string jobTitle)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(SqlQueries.Create(), sqlConnection))
                {

                    sqlCommand.Parameters.AddWithValue("@[No_]", no_);
                    sqlCommand.Parameters.AddWithValue("@[First Name]", firstName);
                    sqlCommand.Parameters.AddWithValue("@[Last Name]", lastName);
                    sqlCommand.Parameters.AddWithValue("@[Job Title]", jobTitle);
                    sqlCommand.Parameters.AddWithValue("@Address", "");
                    sqlCommand.Parameters.AddWithValue("@[E - Mail]", "");
                    sqlCommand.Parameters.AddWithValue("@[Phone No_]", "");
                    sqlCommand.Parameters.AddWithValue("@[No_ Series]", "");
                    sqlCommand.Parameters.AddWithValue("@[Middle Name]", "");
                    sqlCommand.Parameters.AddWithValue("@Initials", "");
                    sqlCommand.Parameters.AddWithValue("@[Search Name]", "");
                    sqlCommand.Parameters.AddWithValue("@[Address 2]", "");
                    sqlCommand.Parameters.AddWithValue("@[Post Code]", "");
                    sqlCommand.Parameters.AddWithValue("@County", "");
                    sqlCommand.Parameters.AddWithValue("@[Mobile Phone No_]", "");
                    sqlCommand.Parameters.AddWithValue("@City", "");
                    sqlCommand.Parameters.AddWithValue("@[Alt_ Address Code]", "");
                    sqlCommand.Parameters.AddWithValue("@[Alt_ Address Start Date]", "");
                    sqlCommand.Parameters.AddWithValue("@[Alt_ Address End Date]", "");
                    sqlCommand.Parameters.AddWithValue("@[Birth Date]", "");
                    sqlCommand.Parameters.AddWithValue("@[Social Security No_]", "");
                    sqlCommand.Parameters.AddWithValue("@[Union Code]", "");
                    sqlCommand.Parameters.AddWithValue("@[Union Membership No_]", "");
                    sqlCommand.Parameters.AddWithValue("@Sex", "");
                    sqlCommand.Parameters.AddWithValue("@[Country_Region Code]", "");
                    sqlCommand.Parameters.AddWithValue("@[Manager No_]", "");
                    sqlCommand.Parameters.AddWithValue("@[Emplymt_ Contract Code]", "");
                    sqlCommand.Parameters.AddWithValue("@[Statistics Group Code]", "");
                    sqlCommand.Parameters.AddWithValue("@[Employment Date]", "");
                    sqlCommand.Parameters.AddWithValue("@Status", "");
                    sqlCommand.Parameters.AddWithValue("@[Inactive Date]", "");
                    sqlCommand.Parameters.AddWithValue("@[Cause of Inactivity Code]", "");
                    sqlCommand.Parameters.AddWithValue("@[Termination Date]", "");
                    sqlCommand.Parameters.AddWithValue("@[Grounds for Term_ Code]", "");
                    sqlCommand.Parameters.AddWithValue("@[Global Dimension 1 Code]", "");
                    sqlCommand.Parameters.AddWithValue("@[Global Dimension 2 Code]", "");
                    sqlCommand.Parameters.AddWithValue("@[Resource No_]", "");
                    sqlCommand.Parameters.AddWithValue("@[Last Date Modified]", "");
                    sqlCommand.Parameters.AddWithValue("@[Extension]", "");
                    sqlCommand.Parameters.AddWithValue("@Pager", "");
                    sqlCommand.Parameters.AddWithValue("@[Fax No_]", "");
                    sqlCommand.Parameters.AddWithValue("@[Company E - Mail]", "");
                    sqlCommand.Parameters.AddWithValue("@[Title]", "");
                    sqlCommand.Parameters.AddWithValue("@[Salespers__Purch_ Code]", "");

                }

            }
        }

        public void UpdateEmployee(string no_, string firstName, string lastName, string jobTitle)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(SqlQueries.Update(), sqlConnection))
                {

                    sqlCommand.Parameters.AddWithValue("@[No_]", no_);
                    sqlCommand.Parameters.AddWithValue("@[First Name]", firstName);
                    sqlCommand.Parameters.AddWithValue("@[Last Name]", lastName);
                    sqlCommand.Parameters.AddWithValue("@[Job Title]", jobTitle);
                }
            }
        }



        public void DeleteEmployee(string no_)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(SqlQueries.Delete(), sqlConnection))
                {

                    sqlCommand.Parameters.AddWithValue("@[No_]", no_);

                }
            }
        }


        public static List<string> GetEmployees()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(SqlQueries.Update(), sqlConnection);

            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            List<string> allEmployees = new List<string>();

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {

                string no_ = reader["[No_]"].ToString();
                string firstName = reader["[First Name]"].ToString();
                string lastName = reader["[Last Name]"].ToString();
                string jobTitle = reader["[Job Title]"].ToString();

                allEmployees.Add(no_);
                allEmployees.Add(firstName);
                allEmployees.Add(lastName);
                allEmployees.Add(jobTitle);

            }

            return allEmployees;
        }

        public static int CheckIfEmployeeExists(string no_)
        {
            int employeeCount = 0;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(SqlQueries.Count(), sqlConnection);
            sqlCommand.Parameters.AddWithValue("@No_", no_);
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                employeeCount = reader.GetInt32(0);

            }

            return employeeCount;
        }

    }
}