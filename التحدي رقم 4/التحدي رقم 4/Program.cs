using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace التحدي_رقم_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Myvar1 = 7;
            int Myvar2 = 3;
            int temp1 = Myvar1 + Myvar2;
            int temp2 = Myvar1 - Myvar2;
            int temp3 = Myvar1 * Myvar2;
            int temp4 = Myvar1 / Myvar2;
            int temp5 = Myvar1 % Myvar2;

            string Mystr1 = "I am ";
            string Mystr2 = "smart";
            string temp6 = Mystr1 + Mystr2;

            Console.WriteLine($"{temp1}\n{temp2}\n{temp3}\n{temp4}\n{temp5}\n{temp6}");
            Console.ReadKey();

        }
    }
}
