using System;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task 03
            5 reqemli eded verilib. 
            Bu ededin evvel 18 % sonra ise 3 % tap
          */
           
            int a  = Convert.ToInt32(Console.ReadLine());

            if (a < 10000 || a >= 100000)
            {
                Console.WriteLine("5 reqemli eded deyil");
                return;
            }
            double b = (a * 18) / 100;
            double c = (a * 3) / 100;

            Console.WriteLine($"18% -- {b}");
            Console.WriteLine($"3% -- {c}");
            





        }
    }
}
