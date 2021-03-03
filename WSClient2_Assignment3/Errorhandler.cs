using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSClient2_Assignment3
{
    class Errorhandler
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

    

