using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Foreach_المصفوفات_ودالة_التكرار
{
    class Program
    {
        static void Main(string[] args)
        {
            // const int myarraysiz = 5;
            // int[] mynumber = new int [myarraysiz] { 1, 3, 5, 7, 9 };

            // for (int i = 0; i < 6; i++) 
            // Console.WriteLine($"my number {( i +1 )}  =  { mynumber[i]}");

            // foreach (int item in mynumber)
            // {
            //     Console.WriteLine($"my number is   =  { item}");

            // }

            // Console.ReadKey();

            int i = 0;
            const int myarraysiz = 15;
            int[] mynumber = new int[myarraysiz] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60 };
            foreach (int item in mynumber)
            {
                 i++;
                if (i > 14)
                    break;
                Console.WriteLine($"{item}");
             
            }
           

           Console.ReadKey();

        }
    }
}
