using System;

namespace Beecrowd
{
    class Problem1142
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{1 + 4 * i} {2 + 4 * i} {3 + 4 * i} PUM");
        }
    }
}