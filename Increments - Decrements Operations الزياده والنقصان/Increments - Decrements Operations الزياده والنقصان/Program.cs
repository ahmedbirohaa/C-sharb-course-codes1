using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increments___Decrements_Operations_الزياده_والنقصان
{
    class Program
    {
        static void Main(string[] args)
        {
            int Myvar1 = 5;
            int Myvar2 = 7;
            int Myvar3 = 2;
           int temp1 =  Myvar1 ++ ;
           // int temp1 = ++Myvar1;
            int temp2 = Myvar2 --/ ++ Myvar3;
            Console.WriteLine($"{temp1}\n{temp2}");
            Console.ReadKey();

        }
    }
}
