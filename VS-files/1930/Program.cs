using System;

namespace Beecrowd
{
    class Problem1930
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] stripCounts = Array.ConvertAll(input, int.Parse);

            int totalDevices = 0;

            foreach(int stripCount in stripCounts)
                totalDevices += stripCount;
            
            int maxDevices = totalDevices - 3;

            Console.WriteLine(maxDevices);
        }
    }
}