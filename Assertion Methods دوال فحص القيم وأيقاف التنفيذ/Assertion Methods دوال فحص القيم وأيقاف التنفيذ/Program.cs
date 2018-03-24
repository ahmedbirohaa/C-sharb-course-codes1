using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace Assertion_Methods_دوال_فحص_القيم_وأيقاف_التنفيذ
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter your value");
            int i = Convert.ToInt32(ReadLine());
            if(i>=100)
            {
                WriteLine($"{i}");
            }
            else
            {
                Debug.Write(" we are here");
               // Debug.Assert(i >= 100, "Short", "Long");
                Trace.Assert(i >= 100);
            }
            WriteLine("Don");
            ReadKey();
        }
    }
}
