using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDesktopApp
{
    static class Program
    {
        

  
        [STAThread]
        static void Main()
        {
            Console.WriteLine("HEJ");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }

    }
}
