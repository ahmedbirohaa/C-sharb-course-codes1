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
             
            int mywhith = 120, a = 83, b = 1;
            for (int i = 1; mywhith>a; i++)
            {
                mywhith -= b;
                Console.WriteLine("{0}", i);
            }
                       Console.ReadKey();


            int mysalary = 1000, a = 20, b = 2000;
            for (int i = 0; mysalary<b; i++)
            {
                mysalary += a;
                float years = i / 12;
                Console.WriteLine("{0}", years);
            }
            Console.ReadKey();*/


            int a = 120, b = 83, c = 1;
            for(int i=0; a>b; i--)
            {
                a -= c;
                Console.WriteLine("{0}", i);
            }

            Console.ReadKey();
        }
    }
}
