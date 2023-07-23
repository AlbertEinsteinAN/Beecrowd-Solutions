using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1160
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int pA = int.Parse(inputs[0]);
                int pB = int.Parse(inputs[1]);
                int time = 0;
                double g1 = double.Parse(inputs[2]);
                double g2 = double.Parse(inputs[3]);
                
                while (pA <= pB)
                {
                    pA += (int)(pA * (g1 / 100.0));
                    pB += (int)(pB * (g2 / 100.0));
                    time++;

                    if (time > 100)   
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }                                     
                }

                if (time <= 100) 
                    Console.WriteLine($"{time} anos.");
            }
        }
    }
}