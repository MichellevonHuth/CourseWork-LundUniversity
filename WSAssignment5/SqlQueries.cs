using System;
namespace WSAssignment5
{
    public class SqlQueries
    {

        public static string Create()

        {
            string sqlCommand = "INSERT INTO[CRONUS Sverige AB$Employee] (@[No_], @[First Name], @[Last Name], @[Job Title], @Address, @[E - Mail], @[Phone No_], @[No_ Series], @[Middle Name], @Initials, @[Search Name], @[Address 2], @[Post Code], @County, @[Mobile Phone No_], @City, @[Alt_ Address Code], @[Alt_ Address Start Date], @[Alt_ Address End Date], @[Birth Date], @[Social Security No_], @[Union Code], @[Union Membership No_], @Sex, @[Country_Region Code], @[Manager No_], @[Emplymt_ Contract Code], @[Statistics Group Code],@[Employment Date], @Status, @[Inactive Date], @[Cause of Inactivity Code], @[Termination Date], @[Grounds for Term_ Code], @[Global Dimension 1 Code], @[Global Dimension 2 Code], @[Resource No_], @[Last Date Modified], @[Extension], @Pager, @[Fax No_], @[Company E - Mail], @[Title], @[Salespers__Purch_ Code])";

            return sqlCommand;

        }


        public static string GetEmployees()
        {
            string sqlCommand = "SELECT [No_], [First Name], [Last Name], [Job Title] FROM [CRONUS Sverige AB$Employee]";

            return sqlCommand;
        }

        public static string Update()
        {

            string sqlCommand = "UPDATE [CRONUS Sverige AB$Employee] SET [First Name] = @[First Name], [Last Name]= @[Last Name], [Job Title] = @[Job Title] WHERE[No_] = @[No_]";

            return sqlCommand;
        }

        public static string Delete()
        {
            string sqlCommand = "DELETE FROM [CRONUS Sverige AB$Employee] WHERE [No_] = @[No_]";

            return sqlCommand;
        }

      
    }

}