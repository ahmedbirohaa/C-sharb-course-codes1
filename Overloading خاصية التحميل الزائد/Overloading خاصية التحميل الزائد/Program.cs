using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_خاصية_التحميل_الزائد
{
    class Program
    {
        //public static int printnumber (int number)
        //{
        //    return number;
        //}
        //public static double printnumber (double number)
        //{
        //    return number;
        //}

            public static int minivalue (int [] array)
        {
            int myminivalue = array[0];
            for (int i =1; i<array.Length; i++)
            {
                if (array[i] < myminivalue)
                    myminivalue = array[i];
                 
            }
            return (myminivalue);
            
        }
        public static double minivalue (double [] array)
        {
            double myminivalue = array[0];
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] < myminivalue)
                    myminivalue = array[i];

            }
            return myminivalue;
        }
        static void Main(string[] args)
        {
            int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] myarray1 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.10 };
            int minivalu = minivalue(myarray);
            double minivalu1 = minivalue(myarray1);
            
            Console.WriteLine($"{minivalu} \n {minivalu1}");
            Console.ReadKey();

            //int number = 9;
            //Console.WriteLine($"{printnumber(number)}");
            //Console.ReadKey();

        }
    }
}
