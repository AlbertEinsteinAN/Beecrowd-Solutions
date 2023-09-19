using System;

namespace Beecrowd
{
    class Problem2152
    {
        static string Output(int h, int m, int o)
        {
            string timeStr = $"{h:D2}:{m:D2}";
            string actionStr = o == 1 ? "A porta abriu!" : "A porta fechou!";
            return $"{timeStr} - {actionStr}";
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int h = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                int o = int.Parse(input[2]);

                Console.WriteLine(Output(h, m, o));
            }
        }
    }
}