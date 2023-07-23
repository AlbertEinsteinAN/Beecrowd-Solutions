using System;

namespace Beecrowd
{
    class Problem1113
    {
        static void Main(string[] args)
        {
            int x = 0, y = 1;
            while (x != y)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                x = int.Parse(inputs[0]);
                y = int.Parse(inputs[1]);

                if (x > y)
                    Console.WriteLine("Decrescente");
                else if (x < y)
                    Console.WriteLine("Crescente");
            }
        }
    }
}