using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1036
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string[] inputs = Console.ReadLine().Split(' ');
            double a = double.Parse(inputs[0]);
            double b = double.Parse(inputs[1]);
            double c = double.Parse(inputs[2]);
            double delta = b * b - 4 * a * c;
            
            if (delta < 0 || a == 0)
                Console.WriteLine("Impossivel calcular");
            else
            {
                Console.WriteLine($"R1 = {((-1 * b + Math.Sqrt(delta)) / (2 * a)).ToString("F5", culture)}");
                Console.WriteLine($"R2 = {((-1 * b - Math.Sqrt(delta)) / (2 * a)).ToString("F5", culture)}");
            }
        }
    }
}