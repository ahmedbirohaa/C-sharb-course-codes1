using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_values__القيم_المرجعية
{
    class Program
    {
        static void multeb_number (ref int mynumber1,ref int mynmber2)
        {
            mynumber1 *= 4;
            mynmber2 *= 4;
            Console.WriteLine($"{mynumber1} {mynmber2}");
        }
        static void Main(string[] args)
        {
            int mynumber1 = 5;
            int mynumber2 = 10;
            Console.WriteLine($"{mynumber1} {mynumber2}");
            multeb_number(ref mynumber1, ref mynumber2);
            Console.WriteLine($"{mynumber1} {mynumber2}");
            Console.ReadKey();

        }
    }
}
