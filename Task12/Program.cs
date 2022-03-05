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
            
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());

            if (!(a >= 100000 && a < 1000000 && 
                  b >= 100000 && b < 1000000 && 
                  c >= 100000 && c < 1000000 && 
                  d >= 100000 && d < 1000000 ))
            {
                Console.WriteLine("6 reqemli eded deyil");
                return;
            }
            a *= 10; a /= 100;
            b *= 10; b /= 100;
            c *= 10; c /= 100;
            d *= 10; d /= 100;

            double sum = (a + b + c + d) * 15 / 100;
            double result = (((a + b + c + d) * sum) * 10 / 100)* 11 /100;
            Console.WriteLine(result);
            






        }
    }
}
