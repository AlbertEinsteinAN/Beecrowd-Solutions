using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1155
    {
        static void Main(string[] args)
        {
            double s = 0, count = 0;

            CultureInfo culture = new CultureInfo("en-US");

            for (int i = 0; i < 100; i++)
            {
                count++;

                s += 1 / count;
            }

            Console.WriteLine(s.ToString("F2", culture));
        }
    }
}