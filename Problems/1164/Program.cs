using System;

namespace Beecrowd
{
    class Problem1164
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int count = 0, sum = 0;                
                
                while (sum < x)
                {
                    count++;
                    sum += count;                    
                }   

                if (x <= 1)
                    Console.WriteLine($"{x} nao eh perfeito");
                else if (sum == x)   
                    Console.WriteLine($"{x} eh perfeito");
                else
                    Console.WriteLine($"{x} nao eh perfeito");          
            }
        }
    }
}