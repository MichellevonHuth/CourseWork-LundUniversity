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
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO[CRONUS Sverige AB$Employee]([No_], [First Name], [Last Name], [Job Title], Address,[E-Mail], [Phone No_], [No_ Series], [Middle Name], Initials,[Search Name], [Address 2],[Post Code], County, [Mobile Phone No_], City, [Alt_ Address Code],[Alt_ Address Start Date], [Alt_ Address End Date], [Birth Date], [Social Security No_],[Union Code], [Union Membership No_], Sex, [Country_Region Code], [Manager No_], [Emplymt_ Contract Code], [Statistics Group Code],[Employment Date], Status, [Inactive Date], [Cause of Inactivity Code],[Termination Date], [Grounds for Term_ Code], [Global Dimension 1 Code], [Global Dimension 2 Code],[Resource No_],[Last Date Modified],[Extension], Pager, [Fax No_],[Company E-Mail],[Title],[Salespers__Purch_ Code]) VALUES('" + no_ + "', '" + firstName + "', '" + lastName + "', '" + jobTitle + "', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ')", sqlConnection))
                    {
                        sqlCommand.Connection = sqlConnection;

                        sqlCommand.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        public void UpdateEmployee(string no_, string firstName, string lastName, string jobTitle)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("UPDATE [CRONUS Sverige AB$Employee] SET [First Name] = '" + firstName + "', " + "[Last Name] = '" + lastName + "', " + "[Job Title] = '" + jobTitle + "'" + " WHERE No_ = '" + no_ + "'", sqlConnection))
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }






        public void DeleteEmployee(string no_)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM [CRONUS Sverige AB$Employee] WHERE No_ = '" + no_ + "'", sqlConnection))
                {
                    try
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }


        public List<string> GetEmployees()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT No_, [First Name], [Last Name], [Job Title] FROM [CRONUS Sverige AB$Employee]", sqlConnection);

            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<string> allEmployees = new List<string>();

                while (reader.Read())
                {

                    string no_ = reader["No_"].ToString();
                    string firstName = reader["First Name"].ToString();
                    string lastName = reader["Last Name"].ToString();
                    string jobTitle = reader["Job Title"].ToString();

                    allEmployees.Add("No_: " + no_ + "     First Name: " + firstName + "     Last Name: " + lastName + "     Job Title: " + jobTitle);


                }

                return allEmployees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CheckIfEmployeeExists(string no_)
        {
            int employeeCount = 0;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) AS Count from[CRONUS Sverige AB$Employee] where No_ = '" + no_ + "'", sqlConnection);

            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    employeeCount = reader.GetInt32(0);

                }

                return employeeCount;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}