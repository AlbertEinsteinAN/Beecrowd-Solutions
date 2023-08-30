using System;

namespace Beecrowd
{
    class Problem1973
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] star = new int[n];
            int[] sheep = new int[n];
            long totalStar = 0;
            long totalSheep = 0;

            string[] sheepInput = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                sheep[i] = int.Parse(sheepInput[i]);
                star[i] = 0;
            }

            int j = 0;

            while (true)
            {
                if (j == 0 && sheep[j] % 2 == 0)
                {
                    star[j] = 1;
                    if (sheep[j] > 0) sheep[j]--;
                    break;
                }
                else if (j == (n - 1) && sheep[j] % 2 == 1)
                {
                    star[j] = 1;
                    if (sheep[j] > 0) sheep[j]--;
                    break;
                }
                else if (sheep[j] % 2 == 1)
                {
                    if (sheep[j] > 0) sheep[j]--;
                    star[j] = 1;
                    j++;
                }
                else if (sheep[j] % 2 == 0)
                {
                    star[j] = 1;
                    if (sheep[j] > 0) sheep[j]--;
                    j--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                totalSheep += sheep[i];
                totalStar += star[i];
            }

            Console.WriteLine(totalStar + " " + totalSheep);
        }
    }
}
