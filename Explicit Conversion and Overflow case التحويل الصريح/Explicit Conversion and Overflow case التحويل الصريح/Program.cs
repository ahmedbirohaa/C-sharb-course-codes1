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
              Console.ReadKey(); */

            byte mybyte;
            int myint = 350;
            mybyte = (byte)myint;
            Console.WriteLine($"my int = {myint}\n");
            Console.WriteLine($"my byte = {mybyte}");
            Console.ReadKey();
        }
    }
}
