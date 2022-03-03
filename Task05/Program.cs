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

            int a = Convert.ToInt32(Console.ReadLine());

            double procent = 0;

            if (a < 1000 || a >= 10000)
            {
                Console.WriteLine("4 reqemli deyil");
                return;
            }
            else
            {
                a = (a + 40000) * 100 + 44;
                procent = a * 44 / 100.0;

                Console.WriteLine($"{a}\n{procent}");
            }

        }
    }
}
