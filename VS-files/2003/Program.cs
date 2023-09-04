using System;

namespace Beecrowd
{
    class Problem2003
    {
        static void Main(string[] args)
        {
            string line;

            while ((line = Console.ReadLine()) != null)
            {
                string[] time = line.Split(':');
                int hour = int.Parse(time[0]);
                int min = int.Parse(time[1]);

                switch (hour)
                {
                    case 7:
                        Console.WriteLine("Atraso maximo: " + min);
                        break;
                    case 8:
                        Console.WriteLine("Atraso maximo: " + (60 + min));
                        break;
                    case 9:
                        Console.WriteLine("Atraso maximo: " + (120 + min));
                        break;
                    default:
                        Console.WriteLine("Atraso maximo: 0");
                        break;
                }
            }
        }
    }
}