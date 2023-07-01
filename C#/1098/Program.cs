using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1098
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");

            for (double i = 0; i <= 2; i += 0.2)
            {
                for (int j = 0; j <= 2; j++)
                {
                    double n = (i + 1) + j;
                    string numberI = i.ToString("F1", culture);
                    string numberJ = n.ToString("F1", culture);

                    if (numberI.EndsWith(".0"))
                        numberI = numberI.Substring(0, numberI.Length - 2);
                    if (numberJ.EndsWith(".0"))
                        numberJ = numberJ.Substring(0, numberJ.Length - 2);
                        
                    Console.WriteLine($"I={numberI} J={numberJ}");
                }
            }
        }
    }
}