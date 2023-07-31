using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1015
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string[] firstPoint = Console.ReadLine().Split(' ');
            string[] secondPoint = Console.ReadLine().Split(' ');
            double x1 = double.Parse(firstPoint[0]);
            double x2 = double.Parse(secondPoint[0]);
            double y1 = double.Parse(firstPoint[1]);
            double y2 = double.Parse(secondPoint[1]);
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distance.ToString("F4", culture));
        }
    }
}