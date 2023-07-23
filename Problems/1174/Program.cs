using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1174
    {
        static void Main(string[] args)
        {
            double x = 0;

            CultureInfo culture = new CultureInfo("en-US");

            for (int i = 0; i < 100; i++)
            {
                x = double.Parse(Console.ReadLine());

                if (x <= 10)
                {
                    Console.WriteLine($"A[{i}] = {x.ToString("F1", culture)}");
                }
            }
        }
    }
}