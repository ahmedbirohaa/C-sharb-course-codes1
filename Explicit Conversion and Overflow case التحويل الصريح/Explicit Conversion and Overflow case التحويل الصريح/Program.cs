using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion_and_Overflow_case_التحويل_الصريح
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  byte mybyte;
              int myint = 7;
              mybyte = (byte)myint;
              Console.WriteLine($"my int = {myint}\n");
              Console.WriteLine($"my byte = {mybyte}");
              Console.ReadKey(); 

            byte mybyte;
            int myint = 350;
            mybyte = unchecked((byte)myint);
            Console.WriteLine($"my int = {myint}\n");
            Console.WriteLine($"my byte = {mybyte}");
            Console.ReadKey();

            decimal mydec;
            int myint = 350;
            mydec = myint;
            Console.WriteLine($"{mydec}");
            Console.WriteLine($"{myint}");
            Console.ReadKey();*/

            decimal mydec= 11111111111;
            int myint ;
           myint  = unchecked((int) mydec);
            Console.WriteLine($"{mydec}");
            Console.WriteLine($"{myint}");
            Console.ReadKey();

        }
    }
}
