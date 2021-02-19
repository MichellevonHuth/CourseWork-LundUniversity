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


            string str = proxy.HelloWorld();
            int result = proxy.Add(5, 6);
            string line = proxy.TxtFile("C:\\Users\\Administrator\\Desktop\\HelloWorld.txt");
   
            Console.WriteLine(line);
            Console.WriteLine(str);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
