using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1014
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double result = x / y;
            
            Console.WriteLine($"{result.ToString("F3", culture)} km/l");
        }
    }
}