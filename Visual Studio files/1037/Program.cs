using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1037
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            
            if (input > 75 && input <= 100)
                Console.WriteLine("Intervalo (75,100]");
            else if (input > 50 && input <= 75)
                Console.WriteLine("Intervalo (50,75]");
            else if (input > 25 && input <= 50)
                Console.WriteLine("Intervalo (25,50]");
            else if (input >= 0 && input <= 25)
                Console.WriteLine("Intervalo [0,25]");      
            else
                Console.WriteLine("Fora de intervalo");
        }
    }
}