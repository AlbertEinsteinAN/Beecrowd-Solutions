using System;

namespace Beecrowd
{
    class Problem2162
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cndtn = 1;
            int[] ara = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            
            if (n == 2 && ara[0] == ara[1])
                cndtn = 0;
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if ((ara[i] >= ara[i - 1] && ara[i - 1] >= ara[i - 2]) || (ara[i] <= ara[i - 1] && ara[i - 1] <= ara[i - 2]))
                    {
                        cndtn = 0;
                        break;
                    }
                }
            }

            Console.WriteLine((cndtn == 1) ? "1" : "0");
        }
    }
}