using System;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task04
            3 reqemli eded verilib. 
            Bu ededin axirina 7 artir. 
            Sonra cavabin 7% tap
          */
            int a = Convert.ToInt32(Console.ReadLine());
                    
            
            if (a < 100 || a >= 1000)
            {
                Console.WriteLine("3 reqemli eded deyil");
                return;
            }
            double b = (a * 10) + 7;
            double sum = (b * 7) / 100;

            Console.WriteLine($"{sum}");
            
            
        
        
        
        
        
        
        }


    }
}
