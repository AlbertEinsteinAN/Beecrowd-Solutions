using System;

namespace Beecrowd
{
    class Problem1080
    {
        static void Main(string[] args)
        {
            int x = 0, index = 0, bigger = 0, indexBigger = 0;

            for (int i = 0; i < 100; i++)
            {
                x = int.Parse(Console.ReadLine());
                index++;
                if (x > bigger)
                {
                    bigger = x;
                    indexBigger = index;
                }
            }
            Console.WriteLine($"{bigger}\n{indexBigger}");
        }
    }
}