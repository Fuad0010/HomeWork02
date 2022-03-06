using System;

namespace Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task07
           2 dene 5 reqemli eded verilib. 
            Bu ededleri toplayib. 
            Alinan cavabin evveline 
            ve axirina 5 artir. 
            Neticenin 5 % tap
          */

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (!(a >= 10000 && a < 100000 &&
                  b >= 10000 && b < 100000))
            {
                Console.WriteLine("5 reqemli eded deyil");
                return;
            }

            double c = a + b;
            if (c < 100000)
            {
                c += 500000;
                c *= 10; c += 5;
                c *= 5; c /= 100;
            }
            else
            { 
                c += 5000000;
                c *= 10; c += 5;
                c *= 5; c /= 100;
            }
            Console.WriteLine(c);
        }
    }
}

