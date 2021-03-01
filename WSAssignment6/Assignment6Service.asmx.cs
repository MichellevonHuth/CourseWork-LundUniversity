using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSAssignment6
{
    /// <summary>
    /// Summary description for Assignment6Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Assignment6Service : System.Web.Services.WebService
    {
        DataAccessLayer dal;

        public Assignment6Service()
        {
            dal = new DataAccessLayer();
        }

        [WebMethod]
        public List<string[]> MetaDataForEmployeeTable()
        {
            List<string[]> list = dal.MetaDataForEmployeeTable();
            return list;
            
        }

        [WebMethod]
        public List<string[]> EmployeeRelatives()
        {
            List<string[]> list = dal.EmployeeRelatives();
            return list;
        }

        [WebMethod]
        public List<string[]> EmployeeAbsent2004()
        {
            List<string[]> list = dal.EmployeeAbsent2004();
            return list;
        }

        [WebMethod]
        public List<string[]> EmployeeAbsentTheMost()
        {
            List<string[]> list = dal.EmployeeAbsentTheMost();
            return list;
        }

        [WebMethod]
        public List<string[]> AllKeys()
        {
            List<string[]> list = dal.AllKeys();
            return list;
        }

        [WebMethod]
        public List<string[]> AllIndexes()
        {
            List<string[]> list = dal.AllIndexes();
            return list;
        }

        [WebMethod]
        public List<string[]> AllTableConstraints()
        {
            List<string[]> list = dal.AllTableConstraints();
            return list;
        }

        [WebMethod]
        public List<string[]> AllTables1()
        {
            List<string[]> list = dal.AllTables1();
            return list;
        }

        [WebMethod]
        public List<string[]> AllTables2()
        {
            List<string[]> list = dal.AllTables2();
            return list;
        }

        [WebMethod]
        public List<string[]> AllColumns1()
        {
            List<string[]> list = dal.AllColumns1();
            return list;
        }

        [WebMethod]
        public List<string[]> AllColumns2()
        {
            List<string[]> list = dal.AllColumns2();
            return list;
        }
    }
}
