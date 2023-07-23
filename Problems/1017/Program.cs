using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1017
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            int hours = int.Parse(Console.ReadLine());
            int speed = int.Parse(Console.ReadLine());
            double fuel = (double)speed / 12 * (double)hours;

            Console.WriteLine(fuel.ToString("F3", culture));
        }
    }
}