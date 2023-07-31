using System;

namespace Beecrowd
{
    class Problem1159
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()), sum = 0;

            while (x != 0)
            {  
                if (x % 2 != 0)
                    x++;

                for (int i = 0; i < 5; i++)
                    sum += x + 2 * i;

                Console.WriteLine(sum);

                sum = 0;
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}