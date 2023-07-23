using System;

namespace Beecrowd
{
    class Problem1158
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                int x = int.Parse(values[0]);
                int y = int.Parse(values[1]);
                int sum = 0;

                if (x % 2 == 0)
                    x += 1;
                
                for (int j = 0; j < y; j++)
                {
                    sum += x;
                    x += 2;
                }      

                Console.WriteLine(sum);
            }
        }
    }
}