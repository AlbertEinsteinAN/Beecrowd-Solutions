using System;

namespace Beecrowd
{
    class Problem1115
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }

                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }

                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }

                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }

                else 
                {
                    break;
                }
            }
        }
    }
}