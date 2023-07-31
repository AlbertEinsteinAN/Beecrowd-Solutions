using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1005
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double media = (a * 3.5 + b * 7.5) / 11;
            CultureInfo culture = new CultureInfo("en-US");

            Console.WriteLine($"MEDIA = {media.ToString("F5", culture)}");
        }
    }
}