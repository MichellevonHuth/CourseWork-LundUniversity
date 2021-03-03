using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Errorhandler
    {
      
            public static string HandleException(Exception ex)
            {
                string errorMessage;

                if (ex.GetType() == typeof(SqlException))
                {

                    SqlException e = ((SqlException)ex);

                    switch (e.Number)
                    {

                        case 17:
                            errorMessage = "Problem with the connection to the database";
                            break;

                        case 0:
                            errorMessage = "Connection failed, timelimit reached";
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
