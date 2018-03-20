using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Function_دوال_الهيكل_البرمجي
{
    class Program
    {
        struct fullname
        {
            public string myfirstname, mylastname;
            public string print() => myfirstname + "  " + mylastname; 
        }
        static void Main(string[] args)
        {
            fullname myfullname;
            myfullname.myfirstname = "ahmed";
            myfullname.mylastname = "shmah";
           // Console.WriteLine($"{myfullname.myfirstname}  {myfullname.mylastname}");
            Console.WriteLine($"{myfullname.print()}");
            Console.ReadKey();
        }
    }
}
