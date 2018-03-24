using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Multicasting_Delegate_التداخل_بين_النوع_الديلگيت
{
    delegate int mynumber(int mynumber);
    class Program
    {
        static int myxnumber = 3;
        static int add(int number)
        {
            myxnumber += number;
            return myxnumber;
        }
        static int mult(int number)
        {
            myxnumber *= number;
            return myxnumber;
        }
        static void Main(string[] args)
        {
            mynumber n;
            mynumber n1 = new mynumber(add);
            mynumber n2 = new mynumber(mult);
            n1(4);
            Write($"{myxnumber}\n");
            n2(5);
            Write($"{myxnumber}\n");
            n = n1 + n2;
            n(6);
            Write($"{myxnumber}");
            ReadKey();
        }
    }
}
