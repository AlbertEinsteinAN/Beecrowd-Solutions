using System;
using System.Globalization;

namespace Beecrowd
{
    class problem1008
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());            
            double amount = double.Parse(Console.ReadLine());
            CultureInfo culture = new CultureInfo("en-US");

            double salary = hours * amount;

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = U$ {salary.ToString("F2", culture)}");
        }
    }
}