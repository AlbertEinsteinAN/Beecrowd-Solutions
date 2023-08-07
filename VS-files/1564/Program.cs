using System;

namespace Beecrowd
{
    class Problem1564
    {
        static void Main(string[] args)
        {
            int n;

            while (int.TryParse(Console.ReadLine(), out n))
            {
                if (n != 0)
                    Console.WriteLine("vai ter duas!");
                else
                    Console.WriteLine("vai ter copa!");
            }
        }
    }
}