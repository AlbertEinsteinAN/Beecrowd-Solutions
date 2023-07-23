using System;

namespace Beecrowd
{
    class Problem1020
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine()), years = 0, months = 0, days = 0;

            years = age / 365;
            age %= 365;
            months = age / 30;
            days = age % 30;

            Console.WriteLine($"{years} ano(s)\n{months} mes(es)\n{days} dia(s)");
        }
    }
}