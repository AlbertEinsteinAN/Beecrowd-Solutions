using System;

namespace Beecrowd
{
    class Problem1101
    {
        static void Main(string[] args)
        {
            int m = 1, n = 1, sum = 0;

            while (m > 0 && n > 0)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                sum = 0;
                m = int.Parse(inputs[0]);
                n = int.Parse(inputs[1]);
                string numbers = "";

                if (m <= 0 || n <= 0)
                    break;
                
                for (int i = Math.Min(m, n); i <= Math.Max(m, n); i++)
                {
                    numbers += i + " ";
                    sum += i;
                }
                Console.WriteLine($"{numbers}Sum={sum}");
            }
        }
    }
}