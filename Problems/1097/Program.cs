using System;

namespace Beecrowd
{
    class Problem1097
    {
        static void Main(string[] args)
        {
            int n = 1, j1 = 7, j2 = 6, j3 = 5;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"I={n} J={j1}");
                Console.WriteLine($"I={n} J={j2}");
                Console.WriteLine($"I={n} J={j3}");

                n += 2;
                j1 += 2;
                j2 += 2;
                j3 += 2;
            }
        }
    }
}