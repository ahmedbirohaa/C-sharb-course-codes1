using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type_char
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMain = Char.MinValue;
            int charMax = char.MaxValue;
            char Myvar = 'G';
            int Myvarvalue = 'G';
            char Myvarvalue2 = Convert.ToChar(75);
                               
            Console.WriteLine("charMain = {0} charMax = {1} Mycharacter = {2} Myvarvalue Number = {3} my convert value is = {4} ",
                 charMain, charMax, Myvar, Myvarvalue, Myvarvalue2);

            string Mystrin = "This is My variable";

            Console.WriteLine("\n My string is {0}", Mystrin);

            bool Mybool = false;
            Console.WriteLine("\n My bool is {0}", Mybool);

                 Console.ReadKey();
                
                                        
           }
    }
}                                    
                                         
                                      
                   
               
           
      
