using System;

namespace Beecrowd
{
    class Problem1963
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double total = (b - a) / a * 100;

            float percentage = (float)total;

            Console.WriteLine($"{percentage:F2}%");
        }
    }
}