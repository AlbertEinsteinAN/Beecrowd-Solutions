﻿using System;

namespace Beecrowd
{
    class Problem1933
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
            
        }
    }
}