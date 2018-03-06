using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmine = float.MinValue;
            float flmax = float.MaxValue;
            Console.WriteLine("Minvalue = {0} Maxvalue = {1}", flmine, flmax);
            float flVar = 1F / 3;
            double dlVar = 1D / 3;
            decimal dcVar = 1M / 3;
            Console.WriteLine("\nfloat value = {0}\ndouble value = {1}\ndecimal value = {2}", flVar, dlVar, dcVar);
            Console.ReadKey();
        }
    }
}
