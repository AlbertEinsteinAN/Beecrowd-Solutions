using System;

namespace Beecrowd
{
    class Problem1435
    {
        static void Main(string[] args)
        {
            int input;
        
            while (int.TryParse(Console.ReadLine(), out input) && input > 0)
            {
                int[,] array = new int[input, input];

                for (int layer = 0; layer <= input / 2; layer++)
                    for (int i = layer; i < input - layer; i++)
                        for (int j = layer; j < input - layer; j++)
                            array[i, j] = layer + 1;

                for (int i = 0; i < input; i++)
                {
                    for (int j = 0; j < input; j++)
                    {
                        Console.Write(array[i, j].ToString().PadLeft(3));

                        if (j < input - 1)
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}