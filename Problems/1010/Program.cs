using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1010
    {
        static void Main(string[] args)
        {
            double total = 0, amount = 0, value = 0;
            CultureInfo culture = new CultureInfo("en-US");

            for (int i = 0; i < 2; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                amount = double.Parse(inputs[1]);
                value = double.Parse(inputs[2]);
                total += value * amount;
            }
            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", culture)}");
        }
    }
}