using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Function_دالة_الأستدعاء_الذاتي
{
    class Program
    {
        //static int myfun(int myvalue, ref int counter)
        //{
        //    counter++;
        //    if (myvalue == 0)
        //        return 0;
        //    else if (myvalue < 10)
        //    {
        //       return myfun(myvalue + 1, ref counter);
        //    }
        //    return myvalue; 
        //}
        static int myfactor(int n, ref int counter)
        {
            counter++;
            if (n == 0)
                return 1;
            else
            {
                return n * myfactor(n - 1, ref counter);
            }
        }
        static void Main(string[] args)
        {
            int counter = 0, n;
            n = myfactor(5, ref counter);
            Console.WriteLine($"my factor is {n} and my counter is {counter}");
            Console.ReadKey();

            //int conuter = 0, myres;
            //myres = myfun(4, ref conuter);
            //Console.WriteLine($"my reso is {myres} and my conuter is {conuter}");
            //Console.ReadKey();

        }
    }
}
