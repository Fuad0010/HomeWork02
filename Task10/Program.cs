using System;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task10
            3 dene 4 reqemli eded verilib. 
            I ededin 1%-ni, II ededin 2% , 
            III ededin 3 % tap.
            Neticeleri bir birinden cix. 
            Alinan cavabin ustune III ededin 7% faizini gel
          */
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());
            if (!(a >= 1000 && a < 10000 && 
                  b >= 1000 && b < 10000 && 
                  c >= 1000 && c < 10000 ))
            {
                Console.WriteLine("4 reqemli deyil");
                return;
            }

            a = (a * 1) / 100.0;
            b = (b * 2) / 100.0;
            c = (c * 3) / 100.0;

            double sum = a - b - c;
            c = (c * 7) / 100.0;
            sum += c;
            Console.WriteLine(sum);




        }
    }
}
