using System;

namespace Beecrowd
{
    class Problem1143
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = 0;
            double[] values = new double[3];

            for (int i = 0; i < n; i++)
            {  
                j++;
                values[0] = 1;
                values[0] *= j;
                values[1] = Math.Pow(values[0], 2);
                values[2] = Math.Pow(values[0], 3);
                Console.WriteLine($"{values[0]} {values[1]} {values[2]}");  
            }
        }
    }
}