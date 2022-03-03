using System;

namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task06
            4 reqemli eded verilib. 
            Bu ededin evvel 20%-ni , 
            sonra ise cavabin 10% tap. 
            Alinan cavabin kvadratini tap.
          */
            
          int a = Convert.ToInt32(Console.ReadLine());
            double procent1 = 0;
            double procent2 = 0;
            double result = 0;
            if (a < 1000 || a >= 10000)
            {
                Console.WriteLine("4 reqemli eded deyil");
                    return;
            }
            else
            {
                procent1 = a * 20 / 100.0;
                procent2 = procent1 * 10 / 100.0;
                result = Math.Pow(procent2, 2);
                Console.WriteLine($"{procent1}\n{procent2}\n{result}");
            }
             

            






        }
    }
}
