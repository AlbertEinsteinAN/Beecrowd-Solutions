using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1116
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                 
            string[] inputs = new string[2]; 
            CultureInfo culture = new CultureInfo("en-US");
            
            for (int i = 0; i < n; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                double x = int.Parse(inputs[0]);
                double y = int.Parse(inputs[1]);
                double total = x / y;

                if (y == 0)
                    Console.WriteLine("divisao impossivel");
                else
                    Console.WriteLine(total.ToString("F1", culture));
            }            
        }
    }
}