using System;

namespace Beecrowd
{
    class Problem1827
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != null)
            {
                int z = int.Parse(input);

                int[,] ara = new int[z, z];
                int a, b, c, d, e, f, g, x, y;

                for (a = 0; a < z; a++)
                {
                    for (b = 0; b < z; b++)
                        ara[a, b] = 0;
                }

                for (a = 0; a < z; a++)
                    ara[a, a] = 2;

                d = z - 1;

                for (a = 0, b = d; a < z; a++, b--)
                    ara[a, b] = 3;

                c = z / 3;
                e = z - c - c;

                for (f = c, x = 1; x <= e; f++, x++)
                {
                    for (g = c, y = 1; y <= e; g++, y++)
                        ara[f, g] = 1;
                }

                int aa = z % 2 == 1 ? z / 2 : (z / 2) - 1;
                ara[aa, aa] = 4;

                for (a = 0; a < z; a++)
                {
                    for (b = 0; b < z; b++)
                        Console.Write(ara[a, b]);

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
