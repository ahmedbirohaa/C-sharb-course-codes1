using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_arrays__مصفوفة_المصفوفات
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] arr = new int[2][];

            //arr[0] = new int [5] { 1, 3, 5, 7, 9 };
            //arr[1] = new int [4] { 2, 4, 6, 8 };
            //for (int i=0; i<arr.Length; i++)
            //{
            //    Console.Write("the arr ({0})\t", i);
            //    for (int j =0; j<arr[i].Length; j++)
            //    {
            //        Console.Write("{0}", arr[i][j]+" ");
            //    }
            //    Console.WriteLine(" ");
            //}

            double[][] arr = new double[3][];
            arr [0] = new double[6] { 1, 2, 3, 4, 5.5, 6 };
            arr [1] = new double[5] { 7, 8, 9, 10, 11 };
            arr [2] = new double[3] { 12, 13, 14 };
            
            for (int a=0; a<arr.Length; a++)
            {
                Console.Write("my arry ({0})   ", a);

                for (int b=0; b<arr[a].Length; b++)
                {
                    Console.Write("{0}", arr[a][b]+ " ");
                }
                Console.WriteLine(" ");

            }



            Console.ReadKey();

        }
    }
}
