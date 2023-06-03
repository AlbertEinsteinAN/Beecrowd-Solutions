using System;

namespace Beecrowd
{
    class Problem1067
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 1 || n1 > 1000)
            {
                return;
            }
            
            for (int i = 1; i <= n1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}