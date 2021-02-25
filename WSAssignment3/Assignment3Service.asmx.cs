using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSAssignment3
{
    /// <summary>
    /// Summary description for Assignment3Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
  
    public class Assignment3Service : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "I am from the HelloWorld method :)";
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            return a+b;
        }

        [WebMethod]
        public String TxtFile(String filename)
        {
            StreamReader sr = File.OpenText(filename);
            {
                String line = sr.ReadToEnd();
                return line;
            }
        }
    }
}
