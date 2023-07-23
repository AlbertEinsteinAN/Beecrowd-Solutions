using System;

namespace Beecrowd
{
    class Problem1149
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int sum = 0, firstElement = 0, lastElement = 0;

            for (int i = 0; i < values.Length; i++)
            {
                int a = int.Parse(values[i]);
                if (a >= 0)
                {
                    firstElement = a;
                    break;
                }
            }

            for (int i = values.Length - 1; i >= 0; i--)
            {
                int b = int.Parse(values[i]);
                if (b >= 0)
                {
                    lastElement = b;
                    break;
                }
            }

            for (int i = 0; i < lastElement; i++)
                sum += firstElement + i;

            Console.WriteLine(sum);
        }
    }
}