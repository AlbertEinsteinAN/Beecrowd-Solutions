using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1006
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double media = (a * 2 + b * 3 + c * 5) / 10;
            CultureInfo culture = new CultureInfo("en-US");

            Console.WriteLine($"MEDIA = {media.ToString("F1", culture)}");
        }
    }
}