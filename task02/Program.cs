using System;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task 2
            3 reqemli eded verilib.
            Bu ededin axirina hemin ededdin ozunu yapishdir.
            example: 333= 333333;

          */
            
            int a = Convert.ToInt32(Console.ReadLine());
            
            if (a < 100 || a >= 1000)
            {
                Console.WriteLine("3 reqemli eded deyil");
                return;
            }
            int b = a * 1000;
            int c = a + b;
            Console.WriteLine(c);
            





        }
    }
}
