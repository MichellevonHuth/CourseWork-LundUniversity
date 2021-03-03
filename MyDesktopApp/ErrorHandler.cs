using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesktopApp
{
    public class ErrorHandler
    {
        public static string HandleException(Exception ex)
        {
            string errorMessage;

            if (ex.GetType() == typeof(NullReferenceException)) {

                errorMessage = "This object doesn't exist";
            }

		    else if (ex.GetType() == typeof(IndexOutOfRangeException)) {
                errorMessage = "Coudn't find what you are looking for";
            }

		    else if (ex.GetType() == typeof(FormatException)) {
                errorMessage = "Wrong format on input value";
            }

		    else if (ex.GetType() == typeof(SqlException)) {

       
                SqlException e  = ((SqlException)ex);

                switch (e.Number)
                {

                    case 2627:
                        errorMessage = "The object you are trying to add already exists";
                        break;

                    case 17:
                        errorMessage = "Problem with the connection to the database";
                        break;

                    case 0:
                        errorMessage = "Anslutningen misslyckades, tidsgräns uppnåd";
                        break;
                    default:
                        errorMessage = "An unexpected error has occured";
                        break;
                }
            } 
            
            else 
            {
                errorMessage = "An unexpected error has occured";
            }

            return errorMessage;
        }

        public static String ErrorMessageEmptyFields()
        {
            String errorMessage = "Fill in all the fields";
            return errorMessage;
        }

        public static String OnlyCharacters ()
        {
            String errorMessage = "This textbox accepts only alphabetical characters";
            return errorMessage;
        }

        public static String OnlyNumbers()
        {
            String errorMessage = "This textbox accepts only numbers";
            return errorMessage;
        }

    }
}
