using System;

namespace Beecrowd
{
    class Problem1099
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] values = new int[2];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                values[0] = int.Parse(inputs[0]);
                values[1] = int.Parse(inputs[1]);

                if ((values[0] + 1) < values[1])
                {
                    for (int j = values[0] + 1; j < values[1]; j++)
                    {
                        if (j % 2 != 0)
                            sum += j;
                    }
                    Console.WriteLine(sum);
                }
                else if (values[0] > (values[1] + 1))
                {
                    for (int j = values[1] + 1; j < values[0]; j++)
                    {
                        if (j % 2 != 0)
                            sum += j;
                    }
                    Console.WriteLine(sum);
                }
                else
                    Console.WriteLine("0");
                
                sum = 0;
            }
        }
    }
}