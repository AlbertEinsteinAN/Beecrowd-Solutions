using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1048
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double plus = 0;

            CultureInfo culture = new CultureInfo("en-US");

            if (x >= 0 && x <= 400.00)
            {
                plus = x + (x * 0.15);
                Output();
                Console.WriteLine("Em percentual: 15 %");
            }

            else if (x >= 400.01 && x <= 800.00)
            {
                plus = x + (x * 0.12);
                Output();
                Console.WriteLine("Em percentual: 12 %");
            }

            else if (x >= 800.01 && x <= 1200.00)
            {
                plus = x + (x * 0.1);
                Output();
                Console.WriteLine("Em percentual: 10 %");
            }

            else if (x >= 1200.01 && x <= 2000.00)
            {
                plus = x + (x * 0.07);
                Output();
                Console.WriteLine("Em percentual: 7 %");
            }

            else if (x > 2000.00)
            {
                plus = x + (x * 0.04);
                Output();
                Console.WriteLine("Em percentual: 4 %");
            }

            else 
            {
                return;
            }

            void Output()
            {
                double f2 = double.Parse(plus.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine($"Novo salario: {plus.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {(plus - x).ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}