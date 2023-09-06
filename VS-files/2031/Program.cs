using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string jogador1, jogador2;

        for (int i = 0; i < N; i++)
        {
            jogador1 = Console.ReadLine();
            jogador2 = Console.ReadLine();

            if (string.Equals(jogador1, "ataque", StringComparison.OrdinalIgnoreCase) && string.Equals(jogador2, "ataque", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Aniquilacao mutua");
            else if (string.Equals(jogador1, "papel", StringComparison.OrdinalIgnoreCase) && string.Equals(jogador2, "papel", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Ambos venceram");
            else if (string.Equals(jogador1, "ataque", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Jogador 1 venceu");
            else if (string.Equals(jogador2, "ataque", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Jogador 2 venceu");
            else if (string.Equals(jogador2, "papel", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Jogador 1 venceu");
            else if (string.Equals(jogador1, "papel", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Jogador 2 venceu");
            else
                Console.WriteLine("Sem ganhador");
        }
    }
}
