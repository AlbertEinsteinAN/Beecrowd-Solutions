using System;

namespace Beecrowd
{
    class Problem1046
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);

            if (n1 > n2)
            {
                Console.WriteLine($"O JOGO DUROU {24 - n1 + n2} HORA(S)");
            }

            else if (n1 == n2)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }

            else if (n2 > n1)
            {
                Console.WriteLine($"O JOGO DUROU {n2 - n1} HORA(S)");
            }
        }
    }
}