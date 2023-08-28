using System;

namespace Beecrowd
{
    class Problem1962
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(Console.ReadLine());

                if (t < 2015)
                    Console.WriteLine($"{2015 - t} D.C.");
                else if (t == 2015)
                    Console.WriteLine("1 A.C.");
                else
                    Console.WriteLine($"{t - 2014} A.C.");
            }
            
        }
    }
}