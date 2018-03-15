using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Of_String_and_Array_Length_المصفوفات_النصية
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] myfullname = { "ahmed", "mohamed","nabil", "shmah"};
            int myarraylength = myfullname.Length;

            //for (int i = 0; i<myarraylength; i++)
            //{
            //    myfullname[2] = "amr";
            //    Console.Write($"{myfullname[i]}" + " ");
            //}


            foreach (string name in myfullname)
            {
                myfullname[2] = "amr";
                Console.Write($"{name}" + " ");
            }
            Console.WriteLine($"\nmy array lenght is {myarraylength}");
            Console.ReadKey();

        }
    }
}
