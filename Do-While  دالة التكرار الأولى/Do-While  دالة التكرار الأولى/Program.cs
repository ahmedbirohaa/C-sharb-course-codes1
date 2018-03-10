using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While__دالة_التكرار_الأولى
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  double mysalary = 1000.20, total = 0.0;
              int i = 0;
              do
              {
                  total += mysalary;
                  i++;
                  Console.WriteLine("i value eaual {0}", i);
              }
              while (i < 10);
              Console.WriteLine("salary values equal {0}", total);
              Console.ReadKey();
              */
            double a =20, total = 1020.0;
            int i = 0;
            do
            {
                total += a ;
                i++;
                Console.WriteLine("the month of {0}", i);
            }
            while (total <= 2000);
            float years = i / 12;
            Console.WriteLine("years ={0} ", years);
            Console.ReadKey();
        }
    }
}
