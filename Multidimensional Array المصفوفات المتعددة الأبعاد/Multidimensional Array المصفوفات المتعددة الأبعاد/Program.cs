using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Array_المصفوفات_المتعددة_الأبعاد
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] myarray =
            //{
            //    {1, 2, 3, 4},
            //    {1, 3, 5, 7},
            //    {2, 4, 6, 8}
            //};

            //foreach (int number in myarray)
            //{
            //    Console.WriteLine($"{number}" + " ");
            //}
            //for (int i=0; i<3; i++)
            //{
            //    for (int j=0; j<4; j++)
            //    {
            //        Console.Write($"{myarray[ i, j]}"+" ");
            //    }
            //    Console.WriteLine(" ");

            //}

            int[,,] my3darray = new int[2, 2, 3]
            {
                { {1,2,3}, {1,3,5} },
                { {11,12,13}, {11,13,15} }
            };
           // foreach(int mynumer in my3darray)
            //{
              //  Console.WriteLine($"{mynumer}");
            //}
            for (int i=0; i<2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    for( int a=0; a<3; a++)
                    {
                        Console.Write($"{my3darray[i, j, a]}"+" ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");

            }


            Console.ReadKey();


        }
    }
}
