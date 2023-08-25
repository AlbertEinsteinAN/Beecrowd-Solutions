using System;

namespace Beecrowd
{
    class Problem1959
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int L = int.Parse(input[1]);
            long perimeter = (long)N * L;

            Console.WriteLine(perimeter);
        }
    }
}
