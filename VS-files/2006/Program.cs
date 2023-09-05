using System;

namespace Beecrowd
{
    class Problem2006
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] contestants = Console.ReadLine().Split();
            int output = 0;

            for (int i = 0; i < 5; i++)
            {
                if (int.Parse(contestants[i]) == t)
                    output ++;
            }

            Console.WriteLine(output);
        }
    }
}