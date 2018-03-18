using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation_Operationsالمصفوفات_الحرفية
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mystr = "ahmed shmah";
            //char[] mychararry = mystr.ToCharArray();

            //Console.WriteLine($"my array lgh is {mychararry.Length}");
            
            //for (int i = 0;  i < mychararry.Length; i++)
            //{
            //    Console.Write($"{mychararry[i]}");
            //}

            //foreach ( char myname in mychararry)
            //{
            //    Console.WriteLine($"{myname}");
            //}

            string mystr1 = "i am smart";
            

            char[] mychararry = mystr1.ToCharArray();

            Console.Write("he is ");   
            for(int i=5; i<mychararry.Length; i++)
            {

                Console.Write($"{mychararry[i]}");
            }

            Console.ReadKey();
        }
    }
}
