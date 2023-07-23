using System;

namespace Beecrowd
{
    class Problem1177
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] values = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                values[i] = i % t;
            }

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"N[{i}] = {values[i]}");
            }
        }
    }
}