using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1178
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal x = decimal.Parse(Console.ReadLine());
            decimal[] values = new decimal[101];

            values[0] = x;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"N[{i}] = {Math.Round(values[i], 4).ToString("F4", culture)}");
                values[i + 1] = values[i] / 2;
            }
        }
    }
}