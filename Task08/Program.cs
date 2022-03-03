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

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int a4f = a * 4 / 100;
            int b9f = b * 9 / 100;

            double sum = ((a4f + b9f)* 10)/100.0;

            Console.WriteLine(sum);



            








        }
    }
}
