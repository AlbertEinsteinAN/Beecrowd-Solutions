using System;

namespace Beecrowd
{
    class Problem1071
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x2 = 0, y2 = 0, count = 0;

            if (x > y)
            {
                while (x > y2)
                {
                    if (y != y2)
                    {
                        if (y2 % 2 != 0)
                        {
                            count += y2;
                        }
                    }                    
                    y2++;                    
                }

                Console.WriteLine(count);
            }

            else if (y > x)
            {
                while (y > x2)
                {
                    if (x2 % 2 != 0)
                    {
                        count += x2;

                    }
                    x2++;
                }

                Console.WriteLine(count);
            }

            else
            {
                Console.WriteLine("0");
            }
        }
    }
}