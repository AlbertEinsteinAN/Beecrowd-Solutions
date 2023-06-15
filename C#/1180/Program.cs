using System;

namespace Beecrowd
{
    class Problem1180
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), position = 0, smaller = 0;
            int[] x = new int[n];
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                x[i] = int.Parse(input[i]);

                if (i == 0)
                {
                    int firstInput = x[i];
                    smaller = firstInput;
                }

                if (x[i] < smaller)
                {
                    position = i;
                    smaller = x[i];
                }
            }

            Console.WriteLine($"Menor valor: {smaller}");
            Console.WriteLine($"Posicao: {position}");
        }
    }
}