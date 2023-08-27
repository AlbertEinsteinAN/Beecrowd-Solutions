using System;

namespace Beecrowd
{
    class Problem1961
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int p = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[] jumps = new int[n];
            bool win = true;

            string[] values = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
                jumps[i] = int.Parse(values[i]);

            for (int i = 0; i < n - 1; i++)
            {
                if (Math.Abs(jumps[i] - jumps[i + 1]) > p)
                {
                    win = false;
                    break;
                }
            }

            if (win)
                Console.WriteLine("YOU WIN");
            else
                Console.WriteLine("GAME OVER");
        }
    }
}
