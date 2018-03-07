using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_type
{
    class Program
    {
        static void Main(string[] args)
        {
          //  \'  \" \\ \0 \a \b \n \r \t \v \f
          // @ 

            string Mystring =@"Nazar has said""This is a unique course"", and I think so";
            string Mystring2 ="\tyas it is";
            string Mystring3 = Mystring + Mystring2;
            string Mystring4 = "\n \v \f";

            Console.WriteLine("{0}{1}", Mystring3,Mystring4);
            Console.ReadKey();

        }
    }
}
