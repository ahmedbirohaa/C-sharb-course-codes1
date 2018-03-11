using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Loop__دارات_التكرار_المتداخلة
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   for(int i=0; i<3;i++)
               {
                   Console.WriteLine("hello ahmed");
                   for(int j=0;j<2;j++)
                   {
                       Console.WriteLine("\thello world");
                   }
                   Console.WriteLine("\n");
               }
              

            int num1 = 0 ;
                for (int i = 0; i<5;i++)
            {
                num1++;
                Console.WriteLine("tabel of {0}\n", num1);

                for(int num2 = 0,j=0; j<10; j++)
                {
                    num2++;
                   int num3 = num1 * num2;
                    Console.WriteLine("{0}*{1}={2}", num1, num2,num3);

                }
                Console.WriteLine("\n");
            }


            Console.ReadKey(); 

            int num1 = 0;
            for (int i = 0; i < 6; i+=2)
            {
                num1+=2;
                Console.WriteLine("tabel of {0}\n", num1);

                for (int num2 = 0, j = 0; j < 10; j++)
                {
                    num2++;
                    int num3 = num1 * num2;
                    Console.WriteLine("{0}*{1}={2}", num1, num2, num3);

                }
                Console.WriteLine("\n");
            }


            Console.ReadKey();*/



            int num1 = -1;
            for (int i = 0; i < 6; i += 2)
            {
                num1 += 2;
                Console.WriteLine("tabel of {0}\n", num1);

                for (int num2 = 0, j = 0; j < 10; j++)
                {
                    num2++;
                    int num3 = num1 * num2;
                    Console.WriteLine("{0}*{1}={2}", num1, num2, num3);

                }
                Console.WriteLine("\n");
            }


            Console.ReadKey();



        }

    }
}
