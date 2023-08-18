using System;

namespace Beecrowd
{
    class Problem1858
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] values = new int[n];

            for (int i = 0; i < n; i++)
                values[i] = int.Parse(input[i]);
            
            int minIndex = 0;
            int minValue = values[0];

            for (int i = 1; i < n; i++)
            {
                if (values[i] < minValue)
                {
                    minValue = values[i];
                    minIndex = i;
                }
            }
            Console.WriteLine(minIndex + 1);
        }
    }
}