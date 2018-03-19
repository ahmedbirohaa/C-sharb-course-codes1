using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Main_Method_دالة_الرئيسية_للبرنامج
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine($"{args.Length}");
            foreach( string a in args)
            {
                Console.WriteLine($"{a}");
            }
            Console.ReadKey();
            return 0;
        }
        
    }
}
