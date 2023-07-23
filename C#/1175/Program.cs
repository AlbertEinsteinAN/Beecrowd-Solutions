using System;

namespace Beecrowd
{
    class Problem1175
    {
        static void Main(string[] args)
        {
            int[] input = new int[20];
            int count = -1;

            for (int i = 0; i < 20; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 19; i > -1; i--)
            {
                count++;
                Console.WriteLine($"N[{count}] = {input[i]}");
            }
        }
    }
}