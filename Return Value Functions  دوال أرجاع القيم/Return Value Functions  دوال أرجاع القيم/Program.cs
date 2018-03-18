using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Value_Functions__دوال_أرجاع_القيم
{
    class Program
    {

        //static void addnumber (int my1number , int my2number )
        //{
        //    int temp = my1number + my2number;
        //    Console.WriteLine($"{temp}");
        //}

        static int addnumber2(int my1number, int my2number)
        {
            int temp = my1number + my2number;
            return temp;
        }
        static void Main(string[] args)
        {
            int myvar1 = 5, myvar2 = 3;
            //addnumber(myvar1, myvar2);
            Console.WriteLine($"{addnumber2(myvar1, myvar2)}");
            Console.ReadKey();
        }
    }
}
