using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace WSClient1_Assignment4
{
    public class Errorhandler
    {
        public string HandleException(Exception ex)
        {
            string errorMessage;

            if (ex.GetType() == typeof(NullReferenceException))
            {

                errorMessage = "This object doesn't exist";
            }

            else if (ex.GetType() == typeof(IndexOutOfRangeException))
            {
                errorMessage = "Coudn't find what you are looking for";
            }

            else if (ex.GetType() == typeof(SoapException))
            {
                errorMessage = "Connection with web service failed";
            }

            else if (ex.GetType() == typeof(SqlException))
            {

                SqlException e = ((SqlException)ex);

                switch (e.Number)
                {

                    case 17:
                        errorMessage = "Problem with the connection to the database";
                        break;

                    case 0:
                        errorMessage = "Connection failed, timeout reached";
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
    }
}
