using System;

namespace Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task08
            2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
            I ededin 4%-ni tap.
            Sonra II ededin 9% ni tap.
            Sonra Cavalari toplayib 10 %ni tap.
          */

            double a = Convert.ToDouble(Console.ReadLine());
            if (!(a >= 1000 && a < 10000))
            {
                Console.WriteLine("4 reqemli deyil");
                return;
            }
            double b = Convert.ToDouble(Console.ReadLine());
            if (!(b >= 1000000 && b < 10000000))
            {
                Console.WriteLine("7 reqemli deyil");
                return;
            }

            a *= 4; a /= 100;
            b *= 9; b /= 100;

            double sum = ((a + b)* 10)/100;

            Console.WriteLine(sum);

        }
    }
}
