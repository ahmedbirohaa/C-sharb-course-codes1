using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Function_with_String_Type_تحويل_النصوص_الى_كلمات
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr;
            char[] spretor = { ' ','u' };
            Console.WriteLine("enter your string");
            mystr = Console.ReadLine();
            string[] newword;
            newword = mystr.Split(spretor);
            foreach (string word in newword)
            {
              Console.WriteLine($"{word}");
            }
            
            Console.ReadKey();
        }
    }
}
