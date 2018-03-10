using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop_Function_دالة_التكرار_الثالثة
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int mysalary = 1000, total = 0;
             for (int i = 0; i < 12; i++) 
             {
                 total += mysalary;
             }
             Console.WriteLine("my salary is {0}", total);
             Console.ReadKey();
             */
            int mywhith = 120, a = 83, b = 1;
            for (int i = 1; mywhith>a; i++)
            {
                mywhith -= b;
                Console.WriteLine("{0}", i);
            }
           
            Console.ReadKey();
        }
    }
}
