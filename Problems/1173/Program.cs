using System;

namespace Beecrowd
{
    class Problem1173
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"N[{i}] = {n}");

                n *= 2;
            }
        }
    }
}