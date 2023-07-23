using System;

namespace Beecrowd
{
    class Problem1865
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "Thor")
                    Console.WriteLine("Y");
                else
                    Console.WriteLine("N");
            }
        }
    }
}