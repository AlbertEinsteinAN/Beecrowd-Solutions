using System;

namespace Beecrowd
{
    class Problem1144
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] values = new double[3];

            for (int i = 1; i <= n; i++)
            {
                values[0]++;
                values[1] = Math.Pow(values[0], 2);
                values[2] = Math.Pow(values[0], 3);
                
                Console.WriteLine($"{values[0]} {values[1]} {values[2]}");
                Console.WriteLine($"{values[0]} {values[1] + 1} {values[2] + 1}");
            }
        }
    }
}