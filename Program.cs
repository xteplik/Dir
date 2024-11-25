using System;

namespace Lab4_1{
    class Program{

        static void Main(){

            double [] x = new double [16];
            Random rand = new Random();

            for( int i = 0; i < x.Length; i++)
            {
                x[i] = rand.Next(0, 10);
            }

            double [] d = new double [16];
            double counter = 0;

            for(int i = 0; i < x.Length; i++)
                {
                    double k = x[i];
                    d[i] = (Math.Exp(k)+2*Math.Exp(-k))/Math.Sqrt(5+ Math.Sin(k));
                    if(d[i] < 0.1)
                    {
                        counter++;
                    }
                }

            Console.WriteLine("Массив:" + string.Join(",", x));
            Console.WriteLine("Массив:" + string.Join(",", d));
            Console.WriteLine($"Кількість елементів d > 0.1: {counter}");
        }
    }
}

