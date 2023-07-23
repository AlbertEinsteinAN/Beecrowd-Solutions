using System;

namespace Beecrowd
{
    class Problem1019
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine()), hours = 0, minutes = 0, seconds = 0;
            
            hours = input / 3600;
            input %= 3600;
            minutes = input / 60;
            seconds = input %= 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}