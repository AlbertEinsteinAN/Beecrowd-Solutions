using System;

namespace Beecrowd
{
    class Problem1042
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] value = {int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2])};

            Array.Sort(value);
            Console.WriteLine($"{value[0]}\n{value[1]}\n{value[2]}\n");  
            Console.WriteLine($"{input[0]}\n{input[1]}\n{input[2]}");
        }
    }
}