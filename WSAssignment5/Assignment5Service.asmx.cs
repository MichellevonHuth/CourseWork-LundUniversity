using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSAssignment5
{
    /// <summary>
    /// Summary description for Assignment5Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Assignment5Service : System.Web.Services.WebService
    {
        DataAccessLayer dal;

        public Assignment5Service()
        {
            dal = new DataAccessLayer();
        }


        [WebMethod]
        public bool CreateEmployee(string no_, string firstName, string lastName, string jobTitle)
        {

            int ifExist = dal.CheckIfEmployeeExists(no_);
            bool resultOutput = true;

            if (ifExist == 0)
            {
                dal.CreateEmployee(no_, firstName, lastName, jobTitle);
            }

            else if (ifExist != 0)
            {
                resultOutput = false;
            }

            return resultOutput;
     
        }

        [WebMethod]
        public List<string> ReadEmployees()
        {
            List<String> employees = dal.GetEmployees();
            return employees;
        }

        [WebMethod]
        public bool UpdateEmployee(string no_, string firstName, string lastName, string jobTitle)
        {
            int ifExist = dal.CheckIfEmployeeExists(no_);
            bool resultOutput = true;

            if (ifExist == 1)
            {
                dal.UpdateEmployee(no_, firstName, lastName, jobTitle);
            }

            else
            {
                resultOutput = false;
            }

            return resultOutput;
        }

        [WebMethod]
        public bool DeleteEmployee(string no_)
        {
            int ifExist = dal.CheckIfEmployeeExists(no_);
            bool resultOutput = true;

            if (ifExist == 1)
            {
                dal.DeleteEmployee(no_);
            }

            else
            {
                resultOutput = false;
            }

            return resultOutput;
        }

    }
}
