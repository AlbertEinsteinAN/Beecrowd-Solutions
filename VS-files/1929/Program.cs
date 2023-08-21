using System;
using System.Linq;

namespace Beecrowd
{
    class Problem1929
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] sides = input.Select(int.Parse).OrderBy(n => n).ToArray();
            int a = sides[0];
            int b = sides[1];
            int c = sides[2];
            int d = sides[3];

            if (a + b > c || a + b > d || b + c > d)
                Console.WriteLine('S');
            else
                Console.WriteLine('N');
        }
    }
}