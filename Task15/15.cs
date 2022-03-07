using System;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task 15
            7 dene eded verilib.
            Bunlardan 2 denesi 3 reqemlidir. 
            2 denesi 4 reqemlidir. 
            2 denesi 5 reqemlidir.
            1 denesi ise 6 reqemlidir.
            3 reqemli ededleri topla , 
            sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            Sonra neticenin axirina 7 reqemini artir.
            Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            Sonra alinan cavabin ustune gel 6 reqemli ededi.
            Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
            Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
          */
            double a1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            
            if (!(a1 >= 100 && a1 < 1000 &&
                  a2 >= 100 && a2 < 1000 ))
            {
                Console.WriteLine("3 reqemli eded deyil");
                return;
            }

            double a3 = Convert.ToDouble(Console.ReadLine());
            double a4 = Convert.ToDouble(Console.ReadLine());
            
            if (!(a3 >= 1000 && a3 < 10000 &&
                  a4 >= 1000 && a4 < 10000 ))
            {
                Console.WriteLine("4 reqemli eded deyil");
                return;
            }

            double a5 = Convert.ToDouble(Console.ReadLine());
            double a6 = Convert.ToDouble(Console.ReadLine());
            
            if (!(a5 >= 10000 && a5 < 100000 &&
                  a6 >= 10000 && a6 < 100000 ))
            {
                Console.WriteLine("5 reqemli eded deyil");
                return;
            }
            
            double a7 = Convert.ToDouble(Console.ReadLine());

            if (!(a7 >= 100000 && a7 < 1000000))
            {
                Console.WriteLine("6 reqemli eded deyil");
                return;
            }
            else
            {
                //3 reqemli ededleri topla ,
                double a1pa2 = a1 + a2;

                //sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
                double a3va4 = a3 * a4; a1pa2 += a3va4;

                //Sonra neticenin axirina 7 reqemini artir. 
                a1pa2 *= 10; a1pa2 += 7;

                //Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
                double a5pa6 = a5 + a6; a1pa2 += a5pa6;

                //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
                double a1va2 = ((a1 * a2) * 10) + 1; a1pa2 -= a1va2;

                //Sonra alinan cavabin ustune gel 6 reqemli ededi.
                a1pa2 += a7;

                //Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
                double a12p34 = a1 + a2 + a3 + a4; a1pa2 -= a12p34;

                //Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
                a1pa2 *= 18; a1pa2 /= 100; a1pa2 *= 3; a1pa2 /= 100; a1pa2 /= 100;

                //Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
                a1pa2 += a5pa6;

                Console.WriteLine(a1pa2);

                //Biraz qariwiq alindi amma optimal olundu))
            }
        }
    }
}
