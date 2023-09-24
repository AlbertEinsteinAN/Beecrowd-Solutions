using System;

namespace Beecrowd
{
    class Problem2161
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double ans = 0.0;

            while (n > 0)
            {
                ans += 6.0;
                ans = 1.0 / ans;
                n--;
            }

            ans += 3.0;
            Console.WriteLine(ans.ToString("F10"));
        }
    }
}