using System;

namespace Beecrowd
{
    class Problem1983
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestRegistrationNumber = -1;
            double bestScore = -1.0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int registrationNumber = int.Parse(input[0]);
                double score = double.Parse(input[1]);

                if (score >= 8.0 && score > bestScore)
                {
                    bestRegistrationNumber = registrationNumber;
                    bestScore = score;
                }
            }

            if (bestRegistrationNumber != -1)
                Console.WriteLine(bestRegistrationNumber);
            else
                Console.WriteLine("Minimum note not reached");
        }
    }
}