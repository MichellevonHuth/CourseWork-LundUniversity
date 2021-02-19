using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSAssignment4;
using WSClient1_Assignment4;


namespace WSClient1_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            WSAssignment4.DataAccessLayer dal = new WSAssignment4.DataAccessLayer();

  

            List<Account> list = dal.GetAllAccounts();

            foreach(Account a in list)
            {
                Console.WriteLine("Username: " +  a.Username + " " + "Name: " + a.Name + " " + "Surname: " + a.Surename);
            }

            

            Assignment4Service proxy = new Assignment4Service();

            Console.ReadLine();

        }
    }
}
