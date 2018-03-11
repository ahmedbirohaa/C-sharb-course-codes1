using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Command_أمر_التحويل_بين_الانواع
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  double mydou = 2500.45d;
              string mystr1, mystr2;
              //mystr1 = mydou;
              mystr1 = Convert.ToString(mydou);
              mystr2 = mystr1.Substring(0, 2);
              Console.WriteLine($"my doublevar{mydou}");
              Console.WriteLine("my strinvar{0}", mystr1);
              Console.WriteLine("my strinvar{0}", mystr2);
              Console.ReadKey();*/
            float myfloat = 45.56f;
            string mystr1, mystr2;
            mystr1 = Convert.ToString(myfloat);
            mystr2 = mystr1.Substring(2);
            Console.WriteLine($"{myfloat}\n{mystr1}\n{mystr2}");
            Console.ReadKey();

        }
    }
}
