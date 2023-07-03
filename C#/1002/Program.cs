using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1002
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double a = r * r * 3.14159;
            CultureInfo culture = new CultureInfo("en-US");

            Console.WriteLine($"A={a.ToString("F4", culture)}");
        }
    }
}