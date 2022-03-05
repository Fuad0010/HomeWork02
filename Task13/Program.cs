using System;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task13
            5 dene eded verilib. 
            Bunlardan 3 denesi 5 reqemli. 
            2 denesi ise 3 reqemlidir. 
            5 reqemli ededlerin 5% tap,
            neticeleri vur bir birine.
            Sonra 3 reqemli ededlerin 3% tap,
            neticeleri topla. 
            Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.
          */

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (!(a >= 10000 && a < 100000 &&
                  b >= 10000 && b < 100000 &&
                  c >= 10000 && c < 100000 ))
            {
                Console.WriteLine("5 reqemli eded deyil");
                return;
            }

            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());

            if (!(d >= 100 && d < 1000 &&
                  e >= 100 && e < 1000 ))
            {
                Console.WriteLine("3 reqemli eded deyil");
                return;
            }

            a *= 5; a /= 100;
            b *= 5; b /= 100;
            c *= 5; c /= 100;

            double r5cm = a * b * c;

            d *= 3; d /= 100;
            e *= 3; e /= 100;

            double r3cm = d + e;

            r5cm *= 10; r5cm /= 100;
            r3cm *= 10; r3cm /= 100;

            double sum = r5cm + r3cm;
            Console.WriteLine(sum);




        }
    }
}
