using System;

namespace Beecrowd
{
    class Problem2139
    {
        static void Main(string[] args)
        {
            int[] daysInMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 25 };

            while (true)
            {
                string input = Console.ReadLine();
                if (input == null) break;

                string[] tokens = input.Split(' ');
                int month = int.Parse(tokens[0]);
                int day = int.Parse(tokens[1]);

                if (month == 12 && day == 25)
                {
                    Console.WriteLine("E natal!");
                }
                else if (month == 12 && day == 24)
                {
                    Console.WriteLine("E vespera de natal!");
                }
                else if (month == 12 && day > 25)
                {
                    Console.WriteLine("Ja passou!");
                }
                else
                {
                    int daysLeft = daysInMonth[month - 1] - day;
                    for (int i = month; i < 12; i++)
                    {
                        daysLeft += daysInMonth[i];
                    }
                    Console.WriteLine("Faltam " + daysLeft + " dias para o natal!");
                }
            }
        }
    }
}