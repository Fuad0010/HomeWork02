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
                  d >= 100000 && d < 1000000))
            {
                Console.WriteLine("6 reqemli eded deyil");
                return;
            }
            double A = (a * 10) / 100;
            double B = (b * 10) / 100;
            double C = (c * 10) / 100;
            double D = (d * 10) / 100;

            a = (a * 15) / 100;
            b = (b * 15) / 100;
            c = (c * 15) / 100;
            d = (d * 15) / 100;

            double sum = A + B + C + D;
            double result = a + b + c + d;

            result *= sum;
            sum = (sum * 10) / 100;
            sum = (sum * 11) / 100;

            Console.WriteLine(sum);
            






        }
    }
}
