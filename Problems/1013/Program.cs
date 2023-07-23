using System;

namespace Beecrowd
{
    class Problem1013
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            Console.WriteLine($"{Math.Max(a, Math.Max(b, c))} eh o maior");
        }
    }
}