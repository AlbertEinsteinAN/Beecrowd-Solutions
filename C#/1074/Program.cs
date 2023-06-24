using System;

namespace Beecrowd
{
    class Problem1074
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] values = new int[n];

            for (int i = 0; i < n; i++)
            {
                values[i] = int.Parse(Console.ReadLine().Split(' ')[0]);
            }

            for (int i = 0; i < n; i++)
            {
                if ((values[i] < 0) && (values[i] %= 2) == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if ((values[i] < 0) && (values[i] %= 2) != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if ((values[i] > 0) && (values[i] %= 2) == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if ((values[i] > 0) && (values[i] %= 2) != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}