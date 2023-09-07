using System;

namespace Beecrowd
{
    class Problem2057
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int s = int.Parse(input[0]);
            int t = int.Parse(input[1]);
            int f = int.Parse(input[2]);
            int hour = s + t + f;

            if (hour >= 24)
                hour -= 24;
            else if (hour < 0)
                hour += 24;

            Console.WriteLine(hour);
        }
    }
}