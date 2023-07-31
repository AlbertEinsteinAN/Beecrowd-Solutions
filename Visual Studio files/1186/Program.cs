using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1186
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            double[,] array = new double[12, 12];
            double sum = 0;
            char operation = char.Parse(Console.ReadLine());

            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 12; j++)
                    array[i, j] = double.Parse(Console.ReadLine());

            for (int i = 11; i > 0; i--)
                for (int j = 12 - i; j < 12; j++)
                    sum += array[i, j];

            if (operation == 'S')
                Console.WriteLine(sum.ToString("F1", culture));
            else
                Console.WriteLine((sum / 66).ToString("F1", culture));
            // The number 66 comes from: ∑[i = 1, 11] ∑[j = 12 - i, 11] A(i, j)
        }
    }
}