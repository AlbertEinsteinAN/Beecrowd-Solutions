using System;

namespace Beecrowd
{
    class Problem1007
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int difference = a * b - c * d;

            Console.WriteLine($"DIFERENCA = {difference}");
        }
    }
}