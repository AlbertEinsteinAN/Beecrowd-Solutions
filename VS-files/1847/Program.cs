﻿using System;

namespace Beecrowd
{
    class Problem1847
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            if (a > b)
            {
                if (b <= c)
                    Console.WriteLine(":)");
                else if (b > c && (b - c) < (a - b))
                    Console.WriteLine(":)");
                else
                    Console.WriteLine(":(");
            }
            else if (a < b)
            {
                if (b >= c)
                    Console.WriteLine(":(");
                else if (b < c && (c - b) < (b - a))
                    Console.WriteLine(":(");
                else
                    Console.WriteLine(":)");
            }
            else
            {
                if (c > b)
                    Console.WriteLine(":)");
                else
                    Console.WriteLine(":(");
            }
        }
    }
}
