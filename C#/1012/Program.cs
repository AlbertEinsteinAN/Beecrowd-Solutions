using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1012
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");

            string[] values = Console.ReadLine().Split(' ');

            double a = double.Parse(values[0]);
            double b = double.Parse(values[1]);
            double c = double.Parse(values[2]);

            double rectangledTriangle = a * c / 2;
            double circle = c * c * 3.14159;
            double trapezium = (a + b) * c / 2;
            double square = b * b;
            double rectangle = a * b;

            Console.WriteLine($"TRIANGULO: {rectangledTriangle.ToString("F3", culture)}");
            Console.WriteLine($"CIRCULO: {circle.ToString("F3", culture)}");
            Console.WriteLine($"TRAPEZIO: {trapezium.ToString("F3", culture)}");
            Console.WriteLine($"QUADRADO: {square.ToString("F3", culture)}");
            Console.WriteLine($"RETANGULO: {rectangle.ToString("F3", culture)}");
        }
    }
}