using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1011
    {
        static void Main(string[] args)
        {
            double x = int.Parse(Console.ReadLine());
            double volumeSphere = 4 * 3.14159 * x * x * x / 3;
            CultureInfo culture = new CultureInfo("en-US");

            Console.WriteLine($"VOLUME = {volumeSphere.ToString("F3", culture)}");
        }
    }
}