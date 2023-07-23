using System;

namespace Beecrowd
{
    class Problem1150
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int validNumber = x, count = 1;

            while (z <= x)
                z = int.Parse(Console.ReadLine());

            while (validNumber <= z)
            {
                validNumber += x + 1;
                x++;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
