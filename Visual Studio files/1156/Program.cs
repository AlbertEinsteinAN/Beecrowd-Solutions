using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1156
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            double a = 1, b = 1, sum = 0;

            for (int i = 1; a <= 39; i++)
            {
                sum += a / b;
                a += 2; 
                b *= 2;
            }
            Console.WriteLine(sum.ToString("F2", culture));
        }
    }
}