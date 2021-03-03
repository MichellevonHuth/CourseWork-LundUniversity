using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPClient1_Assignment5
{
    class ErrorHandler
    {
        public static String ErrorMessageEmptyFields()
        {
            string errorMessage = "Fill in all the fields";
            return errorMessage;
        }

        public static String OnlyCharacters()
        {
            string errorMessage = "This textbox accepts only alphabetical characters";
            return errorMessage;
        }

        public static String OnlyNumbers()
        {
            string errorMessage = "This textbox accepts only numbers";
            return errorMessage;
        }

        public static string DoesNotExists(string no_)
        {
            string errorMessage = "\r\n" + no_ + " is not registred in the database";
            return errorMessage;

        }
        
        public static string Exists(string no_)
        {
            string errorMessage = "\r\n" + no_ + " already exists";
            return errorMessage;
        }
    }
}
