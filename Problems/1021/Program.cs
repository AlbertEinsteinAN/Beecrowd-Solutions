using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1021
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            double input = double.Parse(Console.ReadLine()) * 100;

            double[] bankNotes = {10000, 5000, 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1};

            Console.WriteLine("NOTAS:");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{(int)(input / bankNotes[i])} nota(s) de R$ {bankNotes[i] / 100}.00");
                input %= bankNotes[i];
            }

            Console.WriteLine("MOEDAS:");

            for (int i = 6; i < 12; i++)
            {
                Console.WriteLine($"{(int)(input / bankNotes[i])} moeda(s) de R$ {(bankNotes[i] / 100).ToString("F2", culture)}");
                input %= bankNotes[i];
            }
        }
    }
}