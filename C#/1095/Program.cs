using System;

namespace Beecrowd
{
    class Problem1095
    {
        static void Main(string[] args)
        {
            int a = 1, b = 60;

            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine($"I={a} J={b}");
                a += 3;
                b -= 5;
            }
        }
    }
}