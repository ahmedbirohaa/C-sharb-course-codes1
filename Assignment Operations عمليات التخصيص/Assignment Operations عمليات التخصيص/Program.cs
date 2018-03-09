using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Operations_عمليات_التخصيص
{
    class Program
    {
        static void Main(string[] args)
        {
            // =, +=, -=, *=, /=, %=

            int Myvar1 = 7, Myvar2 = 2;
             Myvar1 /= ++Myvar2;
          // Myvar1 = Myvar2; // Myvar1 = Myvar2;
           // Myvar1 += Myvar2; // Myvar1 = Myvar1 + Myvar2;
           //  Myvar1 -= Myvar2; // Myvar1 = Myvar1 - Myvar2;
          // Myvar1 *= Myvar2; // Myvar1 = Myvar1 * Myvar2;
          //  Myvar1 /= Myvar2; // Myvar1 = Myvar1 - Myvar2;
          //  Myvar1 %= Myvar2; // Myvar1 = Myvar1 % Myvar2;


            Console.WriteLine(" {0} \n {1} ", Myvar1, Myvar2);
            Console.ReadKey();
               
        }
    }
}
