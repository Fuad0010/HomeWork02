using System;

namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task 01
            4 reqemli eded verilib.
            Bu ededin eveline 7 reqemini , 
            axirinada 8 reqemini artir. 
            Example1: 333= 73338        
          */
            int a = Convert.ToInt32(Console.ReadLine());

            if (!(a < 10000 && a >= 1000))
            {
                Console.WriteLine("4 reqemli deyil");
                return;
            }
            else
            {
                a = ((a + 70000) * 10) + 8;
                Console.WriteLine(a);
            }







        }
    }
}
