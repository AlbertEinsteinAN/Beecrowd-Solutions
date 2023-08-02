using System;

namespace Beecrowd
{
    class Problem1043
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            if (a + b > c && a + c > b && b + c > a)
            {
                double perimeter = a + b + c;
                Console.WriteLine($"Perimetro = {perimeter:F1}");
            }
            else
            {
                double area = ((a + b) * c) / 2.0;
                Console.WriteLine($"Area = {area:F1}");
            }
        }
    }
}