using System;

namespace Beecrowd
{
    class Problem1541
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                
                a = int.Parse(input[0]);

                if (a == 0)
                    break;
                else
                {
                    b = int.Parse(input[1]);
                    c = int.Parse(input[2]);

                    d = a * b;
                    e = (d * 100) / c;
                    f = (int)Math.Sqrt(e);
                    Console.WriteLine(f);
                }
            }
        }
    }
}