using System;

namespace Beecrowd
{
    class Problem1914
    {
        static void Main(string[] args)
        {
            int qt = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < qt; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string[] values = Console.ReadLine().Split(' ');
                int n = int.Parse(values[0]);
                int m = int.Parse(values[1]);
                int sum = n + m;

                if ((sum % 2 == 0 && input[1] == "PAR") || (sum % 2 != 0 && input[1] == "IMPAR"))
                    Console.WriteLine(input[0]);
                else
                    Console.WriteLine(input[2]);
            }
        }
    }
}