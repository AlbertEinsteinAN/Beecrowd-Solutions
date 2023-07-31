using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1041
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);

            if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else if (x < 0 && y < 0)
                Console.WriteLine("Q3");
            else if (x > 0 && y < 0)
                Console.WriteLine("Q4");
            else if (x != 0 && y == 0)
                Console.WriteLine("Eixo X");
            else if (x == 0 && y != 0)
                Console.WriteLine("Eixo Y");
            else
                Console.WriteLine("Origem");
        }
    }
}