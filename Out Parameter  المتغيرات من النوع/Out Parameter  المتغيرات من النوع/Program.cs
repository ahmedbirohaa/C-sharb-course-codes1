using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameter__المتغيرات_من_النوع
{
    class Program
    {
        static int  myminivalue (int[] array,out int myindex )
        {
            int minivalue = array[0];
            myindex = 0;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] < minivalue)
                    minivalue = array[i];
                myindex = i;
            }
            return minivalue;
        }
        static void Main(string[] args)
        {
            int[] myarray = { 5, 7, 9, 11, 13, 15, 17, 19, 3,1 };
            int myindex;
            int a = myminivalue(myarray,out myindex);
            Console.WriteLine($"{a}  {myindex}");
            Console.ReadKey();

        }
    }
}
