using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakPoints_نقاط_التوقف_لفحص_وتتبع_الكمود
{
    class Program
    {
        public static int add(int x, int y)
        {
            int z = x + y;
            return z;
        }
        public static int mult(int x, int y)
        {
            int z = x * y;
            return z;
        }
        public static void print (int z)
        {
            Console.WriteLine($"{z}");
        }
        static void Main(string[] args)
        {
            int mynum2 = 7, mynum3 = 4, mynum1;
            mynum1 = add(mynum2, mynum3);
            print(mynum1);
            mynum1 = mult(mynum2, mynum3);
            print(mynum1);
            Console.ReadKey();
            
        }
    }
}
