using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %

            int Myvar1 = 15;
            int Myvar2 = 10;
            int temp = Myvar1 + Myvar2;
            int temp2 = Myvar2 - Myvar1;
            int temp3 = Myvar1 % Myvar2;
            int temp4 = Myvar1 * Myvar2;
            int temp5 = Myvar1 / Myvar2;
            int temp6 = + Myvar1;
            int temp7 = - Myvar1;
            string Mystr1 = "thes is good? ";
            string Mystr2 = "yes";
            Mystr1 = Mystr1 + Mystr2;
            Console.WriteLine($"{temp}\n{temp2}\n{temp3}\n{temp4}\n{temp5}\n{temp6}\n{temp7}\n{Mystr1}");

           // Console.WriteLine("The result is {0} The result2 is {1} The result3 is {2}", temp, temp2, temp3);
            Console.ReadKey();
               
        }
    }
}
