using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1188
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

            for (int i = 11; i > 6; i--)
                for (int j = 12 - i; j < i; j++)
                    sum += array[i, j];          

            if (operation == 'S')
                Console.WriteLine(sum.ToString("F1", culture));
            else
                Console.WriteLine((sum / 30).ToString("F1", culture));
        }
    }
}