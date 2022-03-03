using System;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task 12
            4 dene 6 reqemli eded verilib. 
            Ededlerin hamisinin 10 faizini tap ve topla. 
            Sonra hamisinin 15 faizini tap ve topla.
            Sonra yekunda alinanlar iki cavabi vur biri birine. 
            Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.
          */
            
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            if (!(a >= 100000 && a < 1000000 && 
                  b >= 100000 && b < 1000000 && 
                  c >= 100000 && c < 1000000 && 
                  d >= 100000 && d < 1000000 ))
            {
                Console.WriteLine("6 reqemli eded deyil");
                return;
            }
            






        }
    }
}
