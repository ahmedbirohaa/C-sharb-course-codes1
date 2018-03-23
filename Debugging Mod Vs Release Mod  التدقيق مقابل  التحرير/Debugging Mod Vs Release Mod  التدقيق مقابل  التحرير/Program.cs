using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace Debugging_Mod_Vs_Release_Mod__التدقيق_مقابل__التحرير
{
    class Program
    {
        public static int add(int x, int y)
        {
            Debug.WriteLine("we starat add");
            int z = x + y;
            Debug.WriteLine("we are done here in add");
            Trace.WriteLine("we are done here in add");

            return z;  
        }
        public static int mult(int x, int y)
        {
            Debug.WriteLine("we start mult");
            int z = x * y;
            Debug.WriteLine("we are done here in mult");
            return z;
        }
        public static void write(int z)
        {
            Debug.WriteLine("we start write");
            WriteLine($"{z}");
            Debug.WriteLine("we are done here in write");
        }
        static void Main(string[] args)
        {
            int mynum1, mynum2 = 4, mynum3 = 7;
            mynum1 = add(mynum2, mynum3);
            write(mynum1);
            mynum1 = mult(mynum2, mynum3);
            write(mynum1);
            ReadKey();

        }
    }
}
