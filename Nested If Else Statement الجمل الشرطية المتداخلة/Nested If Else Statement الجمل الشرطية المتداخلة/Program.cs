using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Else_Statement_الجمل_الشرطية_المتداخلة
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int Myvar1 = 9, Myvar2 = 6;

              if (Myvar1==10)
              {
                  Console.WriteLine("Myvar1 = 9");
                  if(Myvar2 ==7)
                  {
                      Console.WriteLine("Myvar2 = 7");
                  }
                      else { 

                      Console.WriteLine("Myvar2 not equal 7");
                           }

             }
              else { 
                  Console.WriteLine("Myvar1 not equal 9");
             }
             */


            int myvar1 = 10, myvar2 = 2, myvar3 = 8;
            if(myvar1==10)
            {
                Console.WriteLine("myvar1 equal 10");
                if((myvar2<=5)&&(myvar3>=9))
                {
                    Console.WriteLine("myvar2 equal 2 and myvar3 equal 8");
                }
                    else
                    {
                    Console.WriteLine("myvar2 not equal 2 and myvar3 not equal 8");
                    }
           }  
                else
                {
                    Console.WriteLine("myvar1 not equal 10");
                }
            
            Console.ReadKey();
        }
    }
}
