using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Break_Loop_Break_Command_أيقاف_التكرار_مع_الأمر_توقف
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  for(int i = 0; i<=5;i++)
              {
                  Console.WriteLine("hello ahmed");
                  if (i > 2)
                      break;
                  for(int j=0; j<=4; j++)
                  {
                      Console.WriteLine("\thello worled");
                  }
                  Console.WriteLine("\n");
              }
              Console.ReadKey(); */
            for (int x = 1; x <= 10; x++)
            {
                if (x > 6)
                    break;
            for(int y=1; y<=10; y++)
                {
                    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                }
            }
            Console.ReadKey();
                

        }
    }
}
