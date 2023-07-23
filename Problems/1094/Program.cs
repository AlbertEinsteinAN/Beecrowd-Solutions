using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1094
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double Animals = 0, Rabbits = 0, Rats = 0, Frogs = 0;

            CultureInfo culture = new CultureInfo("en-US");

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int quantity = int.Parse(inputs[0]);
                string animalType = inputs[1];
                
                if (inputs[1] == "C")
                {
                    Rabbits += quantity;
                    Animals += quantity;
                }
                else if (inputs[1] == "R")
                {
                    Rats += quantity;
                    Animals += quantity;
                }
                else
                {
                    Frogs += quantity;
                    Animals += quantity;
                }
            }

            double percentageRabbits = (Rabbits / Animals) * 100;
            double percentageRats = (Rats / Animals) * 100;
            double percentageFrogs = (Frogs / Animals) * 100;

            Console.WriteLine($"Total: {Animals} cobaias");
            Console.WriteLine($"Total de coelhos: {Rabbits}");
            Console.WriteLine($"Total de ratos: {Rats}");
            Console.WriteLine($"Total de sapos: {Frogs}");
            Console.WriteLine($"Percentual de coelhos: {percentageRabbits.ToString("F2", culture)} %");
            Console.WriteLine($"Percentual de ratos: {percentageRats.ToString("F2", culture)} %");
            Console.WriteLine($"Percentual de sapos: {percentageFrogs.ToString("F2", culture)} %");
        }
    }
}