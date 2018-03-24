using static System.Console;
using yb = brothers.yong_brothers.brothers;
using ob = brothers.old_brothers.brothers;

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
