using System;

namespace Beecrowd
{
    class Problem1096
    {
        static void Main(string[] args)
        {
            int a = 1;
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"I={a} J={7}");
                Console.WriteLine($"I={a} J={6}");
                Console.WriteLine($"I={a} J={5}");
                
                a += 2;
            }
        }
    }
}