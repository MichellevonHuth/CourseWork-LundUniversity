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
            string errorMessage = "";


            if (ex.GetType() == typeof(System.IO.FileNotFoundException))
            {
                errorMessage = "This file doesn't exist";
            }

            else if (ex.GetType() == typeof(System.Net.WebException))
            {
                errorMessage = "Connection to web server failed";
            }

            if (ex.GetType() == typeof(NullReferenceException))
            {

                errorMessage = "This file doesn't exist";
            }

            else if (ex.GetType() == typeof(IndexOutOfRangeException))
            {
                errorMessage = "Coudn't find what you are looking for";
            }

            else
            {
                errorMessage = "An unexpected error has occured";
            }


            return errorMessage;

        }

    }
}

    

