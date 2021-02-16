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
            Assignment3ServiceReference.Assignment3ServiceSoapClient client = new Assignment3ServiceReference.Assignment3ServiceSoapClient();
            string str = client.HelloWorld();
            string hej = client.HelloWld();

            Console.WriteLine(str);
            Console.WriteLine(hej);
            Console.ReadLine();
        }
    }
}
