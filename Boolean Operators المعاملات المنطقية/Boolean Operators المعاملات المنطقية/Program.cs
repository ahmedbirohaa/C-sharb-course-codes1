using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Operators_المعاملات_المنطقية
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison ==, !=, <, >, <=, >=
            // Boolean conditions &&, ||
            bool Myres;
            int Myvar1 = 9, Myvar2 = 11;
           // Myres = Myvar1 != 10;
            Myres = Myvar1 < 10 || Myvar2 <= 12;
            Console.WriteLine("{0}", Myres);
            Console.ReadKey();
        }
    }
}
