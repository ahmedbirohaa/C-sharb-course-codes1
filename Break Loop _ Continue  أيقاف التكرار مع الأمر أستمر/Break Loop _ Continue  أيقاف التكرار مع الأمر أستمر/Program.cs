using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Loop___Continue__أيقاف_التكرار_مع_الأمر_أستمر
{
    class Program
    {
        static void Main(string[] args)
        {
           /* for (int i=0;i<=5;i++)
            {
                Console.WriteLine("Hello ahmed");
                if (i > 2)
                    continue;
                for(int j=0;j<=4;j++)
                {
                    Console.WriteLine("\tHello worled");

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();*/

            for(int x=1;x<=10;x++)
            {
                Console.WriteLine("The tabel of number {0}", x);
                if (x > 6)
                    continue;
                for(int y=1; y<=10;y++)
                {
                    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                }
            }
            Console.ReadKey();
        }
    }
}
