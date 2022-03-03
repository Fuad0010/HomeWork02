using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task 11
            4 dene 5 reqemli eded verilib. 
            Her I ededin ustune III ededi gel . 
            II ededin usutune IV eeddi gel.
            Sonra cavablari vur birbirine. 
            Alinan neticeden III ededin 3%-ni cix.
          */

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            if (!( a >= 10000 && a < 100000 && 
                   b >= 10000 && b < 100000 && 
                   c >= 10000 && c < 100000 &&
                   d >= 10000 && d < 100000 ))
            {
                Console.WriteLine("5 reqemli eded deyil");
                return;
            }
            a += c;
            b += d;
            double sum = a * b;
            double f3 = (c * 3) / 100.0;

            Console.WriteLine(sum - f3);






        }
    }
}
