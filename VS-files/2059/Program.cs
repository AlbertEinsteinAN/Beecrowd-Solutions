using System;

namespace Beecrowd
{
    class Problem2059
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int p = int.Parse(input[0]);
            int j1 = int.Parse(input[1]);
            int j2 = int.Parse(input[2]);
            int r = int.Parse(input[3]);
            int a = int.Parse(input[4]);

            if (r == 1 && a == 1)
                Console.WriteLine("Jogador 2 ganha!");
            else if (r == 0 && a == 1)
                Console.WriteLine("Jogador 1 ganha!");
            else if (r == 1 && a == 0)
                Console.WriteLine("Jogador 1 ganha!");
            else
            {
                if ((j1 + j2) % 2 == p)
                    Console.WriteLine("Jogador 2 ganha!");
                else
                    Console.WriteLine("Jogador 1 ganha!");
            }
        }
    }
}