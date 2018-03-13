using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_ForLoopالمصفوفات
{
    class Program
    {
        static void Main(string[] args)
        {
            /* const int myarraysiz = 5;

             int[] mynumber = { 1, 5, 8, 9, 7 };
             int[] mynumber2 = new int [myarraysiz];
             int[] mynumber3 = new int[myarraysiz] { 1, 5, 8, 9, 7 };

             Console.WriteLine($"{mynumber[4]}");
             for (int i = 0; i< 5; i++) 
             Console.WriteLine($" my number {(i + 1)} is {mynumber3[i]}");
             Console.ReadKey();*/

            int[] mynumber = { 1, 3, 5, 7, 9,11,13,15 };
            Console.WriteLine($"{mynumber.Max()}");
            Console.ReadKey();
        }
    }
}
