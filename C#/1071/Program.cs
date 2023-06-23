using System;

namespace Beecrowd
{
    class Problem1071
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = 0, min = 0, max = 0;

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;     
            }

            for (int i = (min + 1); i < max; ++i)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}