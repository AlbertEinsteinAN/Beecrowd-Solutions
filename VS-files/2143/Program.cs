using System;

namespace Beecrowd
{
    class Problem2143
    {
        static void Main(string[] args)
        {
            int t;
            
            while ((t = Convert.ToInt32(Console.ReadLine())) != 0)
            {
                for (int i = 0; i < t; i++)
                {
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n % 2 == 1)
                        Console.WriteLine(n * 2 - 1);
                    else
                        Console.WriteLine(n * 2 - 2);
                }
            }
        }
    }
}