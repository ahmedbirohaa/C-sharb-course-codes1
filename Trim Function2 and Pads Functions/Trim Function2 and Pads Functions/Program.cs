using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim_Function2_and_Pads_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr1, mystr2, mystr3, mystr4, mystr5;
            char[] mytrimchar = { ' ', 'a', 's' };
            Console.WriteLine("ples inter yore string");
            mystr1 = Console.ReadLine();
            mystr2 = mystr1.ToUpper();
            mystr3 = mystr1.ToLower();
            mystr4 = mystr3.Trim(mytrimchar);
            mystr5 = mystr1.PadRight(14, 'e');
            mystr5 = mystr5.PadRight(15, 's');
            mystr5 = mystr5.PadRight(16, 't');
            Console.WriteLine($"{mystr2}\n{mystr3}\n{mystr4}\n{mystr5}");
            Console.ReadKey();
        }
    }
}
