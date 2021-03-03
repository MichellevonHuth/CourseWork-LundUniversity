using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSClient_Assignment3
{
    class ErrorHandler
    {

        public static string HandleException(Exception ex)
        {
            string errorMessage;
            {
                errorMessage = "An unexpected error has occured";
            }

            return errorMessage;
        }

    }
}
