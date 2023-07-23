using System;

namespace Beecrowd
{
    class Problem1866
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), input = 0;

            for (int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                    Console.WriteLine("0");
                else
                    Console.WriteLine("1");
            }
        }
    }
}