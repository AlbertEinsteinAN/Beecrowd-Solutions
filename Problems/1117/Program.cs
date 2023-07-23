using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1117
    {
        static void Main(string[] args)
        {
            double a = -1, b = -1;
            CultureInfo culture = new CultureInfo("en-US");

            while (a < 0 || a > 10)
            {
                a = double.Parse(Console.ReadLine());
                if (a < 0 || a > 10)
                    Console.WriteLine("nota invalida");
            }

            while (b < 0 || b > 10)
            {
                b = double.Parse(Console.ReadLine());
                if (b < 0 || b > 10)
                    Console.WriteLine("nota invalida");
            }            
            Console.WriteLine($"media = {(a + b) / 2}");
        }
    }
}