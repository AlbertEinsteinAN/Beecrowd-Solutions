using System;

namespace Beecrowd
{
    class Problem1134
    {
        static void Main(string[] args)
        {
            int alcohol = 0, gasoline = 0, diesel = 0, input = 0;;

            while (input != 4)
            {
                input = 0;
                while (input < 1 || input > 4)
                    input = int.Parse(Console.ReadLine());

                if (input == 1)
                    alcohol++;
                else if (input == 2)
                    gasoline++;
                else if (input == 3)
                    diesel++;
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcohol}");
            Console.WriteLine($"Gasolina: {gasoline}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}