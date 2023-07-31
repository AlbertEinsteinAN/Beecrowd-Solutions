using System;

namespace Beecrowd1176
{
    class Problem1176
    {
        static void Main(string[] args)
        {
            long a = 0, b = 1, c = 1, n = 0, limit = long.Parse(Console.ReadLine());
            long[] values = new long[100];

            for (int i = 0; i < 100; i ++)
            {
                values[i] = a;
                c = a + b;
                a = b;
                b = c;
            }
            
            for (int i = 0; i < limit; i++)
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Fib({x}) = {values[x]}");
            }
        }
    }
}