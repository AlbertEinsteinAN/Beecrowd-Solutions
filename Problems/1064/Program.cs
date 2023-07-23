using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1064
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine());
            double n5 = double.Parse(Console.ReadLine());
            double n6 = double.Parse(Console.ReadLine());
            double average = 0, positiveNumbers = 0;
            double total = 0;

            if (n1 >= 0)
            {
                positiveNumbers++;
                average += n1;
            }

            if (n2 >= 0)
            {
                positiveNumbers++;
                average += n2;
            }

            if (n3 >= 0)
            {
                positiveNumbers++;
                average += n3;
            }

            if (n4 >= 0)
            {
                positiveNumbers++;
                average += n4;
            }

            if (n5 >= 0)
            {
                positiveNumbers++;
                average += n5;
            }

            if (n6 >= 0)
            {
                positiveNumbers++;
                average += n6;
            }

            total = average / positiveNumbers;

            Console.WriteLine($"{positiveNumbers} valores positivos");
            Console.WriteLine(total.ToString("F1", CultureInfo.InvariantCulture));         
        }
    }
}