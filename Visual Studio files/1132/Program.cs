using System;

namespace Beecrowd
{
    class Problem1132
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = 0;

            if (x < y)
            {
                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                    {
                        sum += i;
                    }             
                }
            }

            else if (x > y)
            {
                for (int i = y; i <= x; i++)
                {
                    if (i % 13 != 0)
                    {
                        sum += i;
                    }             
                }                
            }
            
            else
            {
                Console.WriteLine("0");
                return;
            }

            Console.WriteLine(sum);
        }
    }
}