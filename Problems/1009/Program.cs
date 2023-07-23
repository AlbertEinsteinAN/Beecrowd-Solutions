using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1009
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            double sale = double.Parse(Console.ReadLine());
            double total = salary + 0.15 * sale;
            CultureInfo culture = new CultureInfo("en-US");

            Console.WriteLine($"TOTAL = R$ {total.ToString("F2", culture)}");
        }
    }
}