using System;

namespace Beecrowd
{
    class Problem1837
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int q, r;

            if (a < 0)
            {
                int x = Math.Abs(b);
                for (r = 0; r < x; r++)
                {
                    int y = a - r;
                    if (y % b == 0)
                    {
                        q = y / b;
                        Console.WriteLine($"{q} {r}");
                        return;
                    }
                }
            }
            else
            {
                q = a / b;
                r = a % b;
                Console.WriteLine($"{q} {r}");
            }
        }
    }
}
