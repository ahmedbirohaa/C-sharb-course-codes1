using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Methodsدوال_الادخال
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string myname, mynumber;
              int myvar1, myvar2;
              char mychar;

              Console.WriteLine("inter your name");
              myname = Console.ReadLine();

              Console.WriteLine("inter number");
              //mynumber = Console.ReadLine();
              myvar1 = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("inter entry");
              //myvar2 = Console.Read();
              mychar = Convert.ToChar(Console.Read());

              Console.WriteLine($"Hello {myname}");
              Console.WriteLine($"your number {myvar1}");
              Console.WriteLine($"your entry {mychar}");
              Console.ReadKey();*/


            string firstname, lastname;
            decimal salary, taxrate, salary2, taxrate2, salary3;

            Console.WriteLine("inter your first name");
            firstname = Console.ReadLine();

            Console.WriteLine("inter your last name");
            lastname = Console.ReadLine();

            Console.WriteLine("inter your salary");
            salary = Convert.ToDecimal( Console.ReadLine());

            Console.WriteLine("inter your taxrate");
            taxrate = Convert.ToDecimal(Console.ReadLine());

            salary2 = salary * 12 ;
            taxrate2 = taxrate * salary2;
            salary3 = salary2 - taxrate2;       

            Console.WriteLine($"Hello {firstname} {lastname}");
            Console.WriteLine($"your salary in the year {salary3} $ ");
            Console.WriteLine($"your tax in the year {taxrate2} $ ");
            Console.WriteLine("good bay");
            Console.ReadKey();


        }
    }
}
