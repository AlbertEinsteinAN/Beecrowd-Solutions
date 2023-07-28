using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1038
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string[] input = Console.ReadLine().Split(' ');
            double[] price = {4.00, 4.50, 5.00, 2.00, 1.50};
            int code = int.Parse(input[0]);
            double quantity = double.Parse(input[1]);
            double total = price[code - 1] * quantity;

            Console.WriteLine($"Total: R$ {total.ToString("F2", culture)}");
        }
    }
}