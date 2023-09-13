using System;

namespace Beecrowd
{
    class Problem2140
    {
        static void Main(string[] args)
        {
            int n, m, net, i, cndtn;
            int[] bill = {7, 12, 22, 52, 102, 15, 25, 55, 105, 30, 60, 110, 70, 120, 150};

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                n = int.Parse(input[0]);
                m = int.Parse(input[1]);

                if (n == 0 && m == 0)
                    break;
                
                net = m - n;
                cndtn = 0;

                for (i = 0; i < 15; i++)
                {
                    if (bill[i] == net)
                    {
                        cndtn = 1;
                        break;
                    }
                }

                if (cndtn == 1)
                    Console.WriteLine("possible");
                else
                    Console.WriteLine("impossible");
            }
        }
    }
}