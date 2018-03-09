using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Condition_الشرط_الثلاثي
{
    class Program
    {
        static void Main(string[] args)
        {
            // int myvar = 9;
            // string myresult = (myvar > 10) ? "yes" : "no";
            // Console.WriteLine("{0}", myresult);
            // Console.ReadKey();

            string myname = "Ahmed", result;
            result = (myname.Equals("ahmed")) ? "yes" : "no";
            Console.WriteLine("{0}", result);
            Console.ReadKey();
        }
    }
}
