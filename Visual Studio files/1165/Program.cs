using System;

namespace Beecrowd
{
    class Problem1165
    {
        static bool IsPrime(int x)
        {
            if (x < 2)
            {
                return false;
            }

            int sum = (int)Math.Sqrt(x) + 1;

            for (int i = 2; i < sum; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), x = 0;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (IsPrime(x))
                {
                    Console.WriteLine($"{x} eh primo");
                }

                else
                {
                    Console.WriteLine($"{x} nao eh primo");
                }
            }
        }
    }
}