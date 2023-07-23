using System;

namespace Beecrowd
{
    class Problem1153
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;

            if (n <= 0)
            {
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                sum = i * sum;
            }

            Console.WriteLine(sum);
        }
    }
}