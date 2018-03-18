using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper_Vs_ToLower_Trim_Functions_دوال_التحكم_بالخط
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr1, mystr2, mystr3,mystr4;
            char[] mytrimchar = { ' ', 'a', 's' }; 
            Console.WriteLine("ples inter yore string");
            mystr1 = Console.ReadLine();
            mystr2 = mystr1.ToUpper();
            mystr3 = mystr1.ToLower();
            mystr4 = mystr3.Trim(mytrimchar);
            Console.WriteLine($"{mystr2}\n{mystr3}\n{mystr4}");
            Console.ReadKey();
        }
    }
}
