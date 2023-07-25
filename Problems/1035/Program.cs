using System;

namespace Beecrowd
{
    class Problem1035
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]); 
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);
            int d = int.Parse(inputs[3]);

            if (b > c && d > a && c + d > a + b && c >= 0 && d >= 0 && a % 2 == 0)
                Console.WriteLine("Valores aceitos");
            else
                Console.WriteLine("Valores nao aceitos");
        }
    }
}