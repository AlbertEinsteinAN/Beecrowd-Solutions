using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1183
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
            
            for (int i = 0; i < 12; i++)
                for (int j = i + 1; j < 12; j++)
                    sum += array[i, j];

            if (operation == 'S')
                Console.WriteLine(sum.ToString("F1", culture));
            else
                Console.WriteLine((sum / 66).ToString("F1", culture)); 
            // The number 66 comes from: ∑[i = 0,  11] ∑[j = i + 1, 11] A(i, j)
        }
    }
}