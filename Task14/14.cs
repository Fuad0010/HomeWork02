using System;

namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task 14
            6 dene 6 reqemli eded verilib. 
            Evvel hamisini topla . 
            Sonra I ve III ededi bir birine yapishdir ve bir eded al.
            I neticeden II neticeni cix. 
            Alinan cavabin 10% tap. 
            Neticenin uzerine V ve VI ededleri gel. 
            Yekunda alinan cavabin 11% tap.
          */

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());

            if (!(a >= 100000 && a < 1000000 &&
                  b >= 100000 && b < 1000000 &&
                  c >= 100000 && c < 1000000 &&
                  d >= 100000 && d < 1000000 &&
                  e >= 100000 && e < 1000000 &&
                  f >= 100000 && f < 1000000))
            {
                Console.WriteLine("6 reqemli eded deyil");
                return;
            }
            else
            {
                double abcdef = a + b + c + d + e + f;

                double ac = a + c;

                abcdef = (((((abcdef - ac) * 10) / 100) + e + f) * 11) / 100;

                Console.WriteLine(abcdef);
            }

        }
    }
}
