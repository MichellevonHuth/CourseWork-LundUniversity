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
        public string CreateEmployee(string no_, string firstName, string lastName, string jobTitle)
        {

            int ifExist = dal.CheckIfEmployeeExists(no_);
            

            string resultOutput = ""; 

            if (ifExist == 0)
            {
                dal.CreateEmployee(no_, firstName, lastName, jobTitle);
            }

            else
            {
               resultOutput = "\r\n" + no_ + " is already taken, try a new one!";
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
        public void UpdateEmployee(string no_, string firstName, string lastName, string jobTitle)
        {
            dal.UpdateEmployee(no_, firstName, lastName, jobTitle);
        }

        [WebMethod]
        public void DeleteEmployee(string no_)
        {
            dal.DeleteEmployee(no_);
        }

    }
}
