using System;

namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task06
            4 reqemli eded verilib. 
            Bu ededin evvel 20%-ni , 
            sonra ise cavabin 10% tap. 
            Alinan cavabin kvadratini tap.
          */
            
          double a = Convert.ToDouble(Console.ReadLine());
            
            if (a < 1000 || a >= 10000)
            {
                Console.WriteLine("4 reqemli eded deyil");
                    return;
            }

            a *= 20;a /= 100;
            a *= 10;a/= 100;
            a *= a;
            

                Console.WriteLine(a);
            
             

            






        }
    }
}
