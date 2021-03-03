using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSClient_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment3Service proxy = new Assignment3Service();
            ErrorHandler errorhandler = new ErrorHandler();

            try
            {
                Console.WriteLine(proxy.HelloWorld());
                Console.WriteLine(proxy.Add(5, 6));
                Console.WriteLine(proxy.TxtFile("C:\\Users\\Administrator\\Desktop\\HelloWorld.txt"));
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                string errormessage = errorhandler.HandleException(ex);
                Console.WriteLine(errormessage);
            }

            Console.ReadLine();

        }
    }
}
