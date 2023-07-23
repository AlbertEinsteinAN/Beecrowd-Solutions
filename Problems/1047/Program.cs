using System;

namespace Beecrowd
{
    class Problem1047
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int x1 = int.Parse(input[0]);
            int y1 = int.Parse(input[1]);
            int x2 = int.Parse(input[2]);
            int y2 = int.Parse(input[3]);
            int start = (x1 * 60) + y1;
            int final = (x2 * 60) + y2;
            int delta;

            if (start < final)
            {
                delta = final - start;
            }

            else
            {
                delta = (((24 * 60) - start) + final);
            }

            int hours = delta / 60;
            int minutes = delta % 60;

            Console.WriteLine($"O JOGO DUROU {hours} HORA(S) E {minutes} MINUTO(S)");
        }
    }
}