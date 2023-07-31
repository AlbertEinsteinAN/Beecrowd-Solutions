using System;

namespace Beecrowd
{
    class Problem1172
    {
        static void Main(string[] args)
        {
            int n = 0;

            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine($"X[{i}] = 1");
                }

                else if (n > 0)
                {
                    Console.WriteLine($"X[{i}] = {n}");
                }
            }
        }
    }
}