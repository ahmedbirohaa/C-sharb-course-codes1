using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumValue_Function__مثال_على_الدوال
{
    class Program
    {
        //static int minivalue(int [] myarray)
        //{
        //    int minivalue = myarray[0];
        //    for(int i=1; i<myarray.Length; i++)
        //    {
        //        if (myarray[i] < minivalue)
        //            minivalue = myarray[i];
        //    }
        //    return minivalue;

        //}
        static double avarage(int [] myarray)
        {
            double myavarage = myarray[0];
            for (int i = 1; i<myarray.Length; i++)
            {
                
                myavarage += myarray[i];
              
            }
            double myava1 = myavarage / 7;
            return myava1;
        }

        static void Main(string[] args)
        {
            //int [] myarray=  { 9,7,5,3,1};
            //int minival =minivalue (myarray);
            //Console.WriteLine($"{minival}");
            //Console.ReadKey();

            int[] myarray = { 50, 60, 70, 75, 80, 90, 95 };
            double myavarage = avarage(myarray);
            Console.WriteLine($"{myavarage}");
            Console.ReadKey();


        }
    }
}
