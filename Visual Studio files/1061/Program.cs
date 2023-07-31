using System;

namespace Beecrowd
{
    class Problem1061
    {
        static void Main(string[] args)
        {
            string[] inputsA = Console.ReadLine().Split(' ');
            int daysA = int.Parse(inputsA[1]);
            string[] inputsB = Console.ReadLine().Split(' ');
            int hoursB = int.Parse(inputsB[0]), minutesB = int.Parse(inputsB[2]), secondsB = int.Parse(inputsB[4]);

            string[] inputsC = Console.ReadLine().Split(' ');
            int daysC = int.Parse(inputsC[1]);
            string[] inputsD = Console.ReadLine().Split(' ');
            int hoursD = int.Parse(inputsD[0]), minutesD = int.Parse(inputsD[2]), secondsD = int.Parse(inputsD[4]);

            int totalSeconds = (secondsD + (minutesD * 60) + (hoursD * 3600) + (daysC * 86400)) - 
            (secondsB + (minutesB * 60) + (hoursB * 3600) + (daysA * 86400));

            int days = totalSeconds / 86400;
            totalSeconds %= 86400;

            int hours = totalSeconds / 3600;
            totalSeconds %= 3600;

            int minutes = totalSeconds / 60;
            
            int seconds = totalSeconds %= 60;

            Console.WriteLine($"{days} dia(s)\n{hours} hora(s)\n{minutes} minuto(s)\n{seconds} segundo(s)");
        }
    }
}