using System;

namespace Beecrowd
{
    class Problem1985
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            double[] values = {1.5, 2.5, 3.5, 4.5, 5.5};
            double sum = 0;
            
            for (int i = 0; i < p; i++)
            {
                string[] input = Console.ReadLine().Split();
                int input0 = int.Parse(input[0]);
                double input1 = double.Parse(input[1]);
                sum += values[input0 - 1001] * input1;
            }
            Console.WriteLine(sum.ToString("F2"));
        }
    }
}