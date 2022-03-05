using System;

namespace Task09
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task09
            3 dene 6 reqemli eded verilib. 
            Her birinin 10 faizini tapib neticeleri topla. 
            Alinan cavabin 10% tap.
          */

            double a = Convert.ToDouble(Console.ReadLine());
            
            

            if (a < 100000 || a >= 1000000)                     //istedim 6 reqemli eded yazmayan 
            {                                                   //kimi srazu atsin returna ona gore 
                Console.WriteLine("6 reqemli eded deyil");      //uzun kod alindi
                return;
            }
            double b = Convert.ToDouble(Console.ReadLine());
            if (b < 100000 || b >= 1000000)                 
            {
                Console.WriteLine("6 reqemli eded deyil");
                return;
            }
            double c = Convert.ToDouble(Console.ReadLine());
            if (c < 100000 || c >= 1000000)
            {
                Console.WriteLine("6 reqemli eded deyil");
                return;
            }
            a = (a * 10) / 100;
            b = (b * 10) / 100;
            c = (c * 10) / 100;

             a = a + b + c;

            double sum = a * 10 / 100;


            Console.WriteLine($"{sum}");



        }
    }
}
