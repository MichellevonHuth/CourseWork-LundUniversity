using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WSAssignment4
{
    /// <summary>
    /// Summary description for Assignment4Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Assignment4Service : System.Web.Services.WebService
    {
        DataAccessLayer dal;

        public Assignment4Service()
        {
            dal = new DataAccessLayer();
        }


        [WebMethod]
        public void InsertUsers(string username, string name, string surename)
        {
            try
            {
                dal.InsertAccount(username, name, surename);
            }
            catch (SqlException ex)
            {
                throw new SoapException("User already exist", SoapException.ClientFaultCode, ex);
            }

        }

        
        [WebMethod]
        public List<Account> GetAccounts()
        {
            List <Account> accounts = dal.GetAllAccounts();              
            return accounts; 
        }

        [WebMethod]
        public List<SavingSchedule> GetSavingSchedules()
        {
            List<SavingSchedule> schedules = dal.GetAllSavingSchedules();
            return schedules;
        }


    }
}
