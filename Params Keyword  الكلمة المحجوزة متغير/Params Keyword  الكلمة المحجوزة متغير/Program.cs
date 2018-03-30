using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Params_Keyword__الكلمة_المحجوزة_متغير
{
    class Program
    {
        static double CA(params double [] values)
        {
            WriteLine("you sent me {0} double", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum = values.Max();
            return (sum );
                    
        }
        static void Main(string[] args)
        {
            double avreag;
            // ..... we can pass arguments
            avreag = CA(4.0, 3.2, 5.7, 64.22, 87.2);
            WriteLine("avreage of date is : {0}", avreag);

            // ..... we can pass an array of double
            double[] date = { 4.0, 3.2, 5.7 };
            avreag = CA(date);
            WriteLine("avreage of date is : {0}", avreag);

            // .... avreae of 0 is 0
            WriteLine("avreage of date is : {0}", CA());
            ReadKey();
        }
    }
}
