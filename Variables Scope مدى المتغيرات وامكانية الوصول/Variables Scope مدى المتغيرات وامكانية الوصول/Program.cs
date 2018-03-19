using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Scope_مدى_المتغيرات_وامكانية_الوصول
{
    class Program
    {
        static string mystring;
        static void print()
        {
            string mystring = " it is my string print";
            Console.WriteLine($"{mystring}");
            Console.WriteLine($"{Program.mystring}");
        }
        static void Main(string[] args)
        {
            string mystring = " it is my string";
            Console.WriteLine($"{mystring}");
             Program.mystring = "it is my string programs";
            print();
            Console.WriteLine($"{Program.mystring}");

            Console.ReadKey();
        }
    }
}
