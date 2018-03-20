using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Type_النوع_المهم_المؤشر_على_الدوال
{
    delegate int mynewnumber(int mynumber);
    class Program
    {
        static int xnumber = 3;
        static int add (int number1)
        {
            xnumber += number1;
            return xnumber;     
        }
        static int mult (int number2)
        {
            xnumber *= number2;
            return xnumber;
        }
        static void Main(string[] args)
        {
            mynewnumber n1 = new mynewnumber(add);
            mynewnumber n2 = new mynewnumber(mult);
            n1(4);
            Console.WriteLine($"{xnumber}");
            n2(5);
            Console.WriteLine($"{xnumber}");
            Console.ReadKey();
        }
    }
}
