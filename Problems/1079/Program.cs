using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1079
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] weights = new double[3];

            CultureInfo culture = new CultureInfo("en-US");

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    weights[j] = double.Parse(input[j]);
                }
                
                double average = ((weights[0] * 2) + (weights[1] * 3) + (weights[2] * 5)) / 10;
                Console.WriteLine(average.ToString("F1", culture));
            }
        }
    }
}