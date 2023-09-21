using System;

namespace Beecrowd
{
    class Problem2159
    {
        static void Main(string[] args)
        {
            double n, ans1, ans2;
            n = double.Parse(Console.ReadLine());

            ans1 = n / Math.Log(n);
            ans2 = 1.25506 * (n / Math.Log(n));

            Console.WriteLine($"{ans1:F1} {ans2:F1}");
        }
    }
}