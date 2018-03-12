using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Type_نوع_السجل
{
    class Program
    {
      //  enum toyota :byte
       // {
        //    rav4 = 1,
         //   camery = 2,
        //    tundra = 3,
         //   highland = 4
       // }
       // struct cartype
      //  {
       //     public toyota modelname;
       //     public double modelyear;
       // }

            enum i :int
        {
            n =1,s=2,e=3,w=4
        }
        struct j
        {
            public i name;
            public int number;

        }
        static void Main(string[] args)
        {
            j myj;
            int etgah ;
            int number;
            Console.WriteLine("1) n\n2) s\n3) e\n4) w");
            do
            {

            
            Console.WriteLine("Enter your etgah");
            etgah = Convert.ToInt32(Console.ReadLine());
            }
            while ((etgah < 1) || (etgah > 4));
            Console.WriteLine("Enter your msafa");
            number = Convert.ToInt32(Console.ReadLine());

            

            myj.name = (i)etgah;
            myj.number = number;
            Console.WriteLine($"my etgah is {myj.name} and my msafa is {myj.number}");
              Console.ReadKey();




            /*  cartype mycartype;
              int cartype =-1 ;
              double modelyear;

              Console.WriteLine("1) rav4\n2) camery\n3) tundra\n4) highland");

              do
              {
                  Console.WriteLine("Enter your car type");
                  cartype = Convert.ToInt32(Console.ReadLine());
              }
              while((cartype < 1) || (cartype > 4));

              Console.WriteLine("Enter your car model");
              modelyear = Convert.ToDouble(Console.ReadLine());

              mycartype.modelname = (toyota)cartype ;
              mycartype.modelyear = modelyear;
              Console.WriteLine($"my car type is {mycartype.modelname} and my car model is {mycartype.modelyear}");
              Console.ReadKey();*/











           
        }
    }
}
