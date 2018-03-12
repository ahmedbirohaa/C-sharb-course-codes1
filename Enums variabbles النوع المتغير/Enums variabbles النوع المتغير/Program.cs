using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_variabbles_النوع_المتغير
{
    class Program
    {
      //  enum humansex :sbyte
      //  {
       //     male =1,female =2
     //   }


            enum A :sbyte
        {
            n = 2, s=3, r=4, l=5
        }
        static void Main(string[] args)
        {
            /*  sbyte humansbyte;
              string humangender;

              humansex myhumansex = humansex.male;
              Console.WriteLine($"Humansex = {myhumansex}");

              humansbyte = (sbyte)myhumansex;
              Console.WriteLine($"index in = {humansbyte}");

              humangender = Convert.ToString(myhumansex);
              Console.WriteLine($" strin = {humangender }");

              Console.ReadKey();*/
            sbyte mysbyte, mysbyt1, mysbyt2, mysbyt3;
            string mystr1, mystr2, mystr3, mystr4;

            A a = A.n;
            A b = A.s;
            A c = A.r;
            A d = A.l;
            Console.WriteLine($" {a}\n {b}\n {c}\n {d}");

            mysbyte = (sbyte)a;
            mysbyt1 = (sbyte)b;
            mysbyt2 = (sbyte)c;
            mysbyt3 = (sbyte)d;
            Console.WriteLine($" {mysbyte}\n {mysbyt1}\n {mysbyt2}\n {mysbyt3}");

            mystr1 = Convert.ToString(a);
            mystr2 = Convert.ToString(b);
            mystr3 = Convert.ToString(c);
            mystr4 = Convert.ToString(d);
            Console.WriteLine($" {mystr1}\n {mystr2}\n {mystr3}\n {mystr4}");


            Console.ReadKey();


        }
    }
}
