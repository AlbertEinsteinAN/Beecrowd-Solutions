using System;

namespace Beecrowd
{
    class Problem1145
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int columns = int.Parse(values[0]);
            int n = int.Parse(values[1]);

            int rows = (int)Math.Ceiling((double)n / columns);
            int[][] array = new int[rows][];

            int count = 1;
            for (int i = 0; i < rows; i++)
            {
                int remaining = n - i * columns;
                int currentColumns = Math.Min(columns, remaining);
                array[i] = new int[currentColumns];

                for (int j = 0; j < currentColumns; j++)
                {
                    array[i][j] = count;
                    count++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                    if (j < array[i].Length - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}