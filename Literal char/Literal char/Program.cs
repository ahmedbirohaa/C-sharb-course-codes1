using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_char
{
    class Program
    {
        static void Main(string[] args)
        {
            int Myvar = -100;
            uint Myuvar = 1000u;
            float Myflvar = 1.5f;
            double Mydvar = 100.5d;
            decimal Mydecvar = 100.5m;

            Console.WriteLine("{0} {1}", Myvar, Myuvar);
            Console.WriteLine($"{Myflvar},{Mydvar},{Mydecvar}");

            Console.ReadKey();

        }
    }
}
