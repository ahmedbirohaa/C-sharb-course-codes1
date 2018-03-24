using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using yb= brothers.yong_brothers.brothers;
using ob= brothers.old_brothers.brothers;

namespace Using_Namespaces_in_Practical__فضاءات_الأسماء
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("thes is my family");
            yb.print();
            ob.print();
            ReadKey();
        }
    }
}
namespace brothers
{
    namespace yong_brothers
    {
        class brothers
        {
            public static void print()
            {
                WriteLine("ahmed and mohamed");
            }
        }
    }
    namespace old_brothers
    {
        class brothers
        {
            public static void print()
            {
                WriteLine("amar and abdalrhman");
            }
               
        }
    }
    

}
