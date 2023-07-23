using System;

namespace Beecrowd
{
    class Problem1018
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] banknotes = {100, 50, 20, 10, 5, 2, 1};
            
            Console.WriteLine(input);

            for (int i = 0; i < 7; i++)
            {     
                Console.WriteLine($"{input / banknotes[i]} nota(s) de R$ {banknotes[i]},00");
                input %= banknotes[i];
            }            
        }
    }
}