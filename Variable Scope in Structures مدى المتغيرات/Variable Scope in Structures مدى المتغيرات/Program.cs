using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Scope_in_Structures_مدى_المتغيرات
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            for (int i = 0; i<10; i++)
            {
                 index = i;
                Console.WriteLine($"{index}");
            }
            Console.WriteLine($"the last index = {index}");
            Console.ReadKey();
        }
    }
}
