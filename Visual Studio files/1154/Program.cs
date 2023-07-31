using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1154
    {
        static void Main(string[] args)
        {
            double sum = 0, result = 0, n = 0, times = 0;
            CultureInfo culture = new CultureInfo("en-US");

            while (n >= 0)
            {  
                times++;
                sum += n;
                n = double.Parse(Console.ReadLine(), culture);
            }

            result = sum / (times - 1);

            Console.WriteLine(result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}