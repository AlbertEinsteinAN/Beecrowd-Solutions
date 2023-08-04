using System;

class Program1534
{
    static void Main(string[] args)
    {
        short tamanho, linha, coluna;

        while (short.TryParse(Console.ReadLine(), out tamanho))
        {
            short[,] matriz = new short[tamanho, tamanho];

            for (linha = 0; linha < tamanho; linha++)
            {
                for (coluna = 0; coluna < tamanho; coluna++)
                {
                    if (linha == coluna)
                        matriz[linha, coluna] = 1;
                    if (linha == tamanho - coluna - 1)
                        matriz[linha, coluna] = 2;
                    if (linha != coluna && linha != tamanho - coluna - 1)
                        matriz[linha, coluna] = 3;
                }
            }

            for (linha = 0; linha < tamanho; linha++)
            {
                for (coluna = 0; coluna < tamanho; coluna++)
                {
                    Console.Write(matriz[linha, coluna]);
                }

                Console.WriteLine();
            }
        }
    }
}
