using System;

namespace Beecrowd
{
    class Problem1133
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int aux = 0;

            if (x > y)
            {
                aux = y;
                y = x;
                x = aux;
            }

            for (int i = (x + 1); i < y; i++)
            {                
                if(i % 5 == 2 || i % 5 == 3)
                    Console.WriteLine(i);
            }
        }
    }
}