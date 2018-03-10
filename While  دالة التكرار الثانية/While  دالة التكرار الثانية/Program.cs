using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While__دالة_التكرار_الثانية
{
    class Program
    {
        static void Main(string[] args)
        
{
            /*  int i = 0;
              double mysalary = 1020.30, total = 0.0;
              while (i < 15)
              {
                  total += mysalary;
                  i++;

              }
              Console.WriteLine("{0}", total);
              Console.ReadKey();
              */
            int i = 0, myweight = 120, a=83;
            while (myweight>a)
            {
                myweight --;
                i++;
            }
            Console.WriteLine("{0}", i);
            Console.ReadKey();

        }
    }
}
