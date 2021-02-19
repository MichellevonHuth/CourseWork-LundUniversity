using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSClient1_Assignment4;


namespace WSClient1_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            WSAssignment4.DataAccessLayer dal = new WSAssignment4.DataAccessLayer();

            dal.InsertAccount("hej", "mich", "mich");

            Assignment4Service proxy = new Assignment4Service();


        
            Console.WriteLine("Hello");
            Console.ReadLine();

        }
    }
}
