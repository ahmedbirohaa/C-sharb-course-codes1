using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lambda_Expression_التعبير_البرمجي_الليمدا
{
    delegate int mynuber(int mynumber);
    class Program
    {
        static int myxnumer = 3;
        static void Main(string[] args)
        {
            //mynuber n = x => x + myxnumer;
            //mynuber n2 = x => x * myxnumer;
            
            //WriteLine($"{n(3)}");
           
            //WriteLine($"{n2(4)}");
            //ReadKey();
            //Func<int, bool> func2 = (x => x % 2 != 0);
            //int []  myarray = { 1,2,3,4,5,7};
            //for (int i =0; i<myarray.Length; i++)
            //{
            //    WriteLine(func2.Invoke(myarray[i]));
            //}
            //ReadKey();

            Func<int, bool> func3 = (x => x > 10);
            int[] myarray1 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            for (int x =0; x<myarray1.Length; x++)
            {
                if (myarray1[x]>10)
                WriteLine($"{func3.Invoke(myarray1[x])} {myarray1[x]}" + " ");

            }
            ReadKey();
        }
    }
}
