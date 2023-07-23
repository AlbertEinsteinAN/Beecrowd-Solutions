using System;

namespace Beecrowd
{
    class Problem1151
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c = 0;

            if (n == 0 || n == 1)
            {
                Console.Write(a);
                return;
            }

            Console.Write(a);

            for (int i = 2; i < n; i++)
            {
                a = b;
                b = c;
                c = a + b;
                
                Console.Write($" {c}");
            }

            Console.WriteLine($" {c + b}");
        }
    }
}