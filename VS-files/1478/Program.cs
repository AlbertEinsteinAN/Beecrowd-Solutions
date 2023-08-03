using System;

namespace Beecrowd
{
    class Problem1478
    {
        static void Main(string[] args)
        {
            int n;

            while (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j > 1) Console.Write(" ");
                        Console.Write($"{Math.Abs(i - j) + 1, 3}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
