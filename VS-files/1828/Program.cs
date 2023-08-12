using System;

namespace Beecrowd
{
    class Problem1828
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= t; i++)
            {
                string[] choices = Console.ReadLine().Split(' ');
                string sheldonChoice = choices[0];
                string rajChoice = choices[1];
                string result = GetResult(sheldonChoice, rajChoice);

                Console.WriteLine($"Caso #{i}: {result}");
            }
        }

        static string GetResult(string sheldon, string raj)
        {
            if (sheldon == raj)
                return "De novo!";
            
            switch (sheldon)
            {
                case "pedra":
                    return raj == "tesoura" || raj == "lagarto" ? "Bazinga!" : "Raj trapaceou!";
                case "papel":
                    return raj == "pedra" || raj == "Spock" ? "Bazinga!" : "Raj trapaceou!";
                case "tesoura":
                    return raj == "papel" || raj == "lagarto" ? "Bazinga!" : "Raj trapaceou!";
                case "lagarto":
                    return raj == "papel" || raj == "Spock" ? "Bazinga!" : "Raj trapaceou!";
                case "Spock":
                    return raj == "tesoura" || raj == "pedra" ? "Bazinga!" : "Raj trapaceou!";
                default:
                    return "Invalid input";
            }
        }
    }
}