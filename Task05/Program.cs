using System;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task05
            4 reqemli eded verilib. 
            Bu ededin evvelin 4 reqemi , 
            axirina ise 44 ededini artir. 
            Alinan cavabin 44 % tap.
         */

            double a = Convert.ToDouble(Console.ReadLine());

            

            if (a < 1000 || a >= 10000)
            {
                Console.WriteLine("4 reqemli deyil");
                return;
            }
            else
            {
                a += 40000; 
                a += 100; 
                a+= 44;
                a *= 44; 
                a/= 100;

                Console.WriteLine(a);
            }

        }
    }
}
