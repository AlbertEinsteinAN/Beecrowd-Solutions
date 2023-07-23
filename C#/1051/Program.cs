using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1051
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            CultureInfo culture = new CultureInfo("en-US");
            
            if (value <= 2000)
                Console.WriteLine("Isento");
            else if (value > 2000 && value <= 3000)
            {
                value = (value - 2000) * 0.08;
                Console.WriteLine($"R$ {value.ToString("F2", culture)}");
            }
            else if (value > 3000 && value <= 4500)
            {
                value = ((value - 3000) * 0.18) + 80;
                Console.WriteLine($"R$ {value.ToString("F2", culture)}");
            }
            else if (value > 4500)
            {
                value = ((value - 4500) * 0.28) + 350;
                Console.WriteLine($"R$ {value.ToString("F2", culture)}");
            }

            else return;
        }
    }
}