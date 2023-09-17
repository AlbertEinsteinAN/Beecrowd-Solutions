using System;

namespace Beecrowd
{
    class Problem2147
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string c = Console.ReadLine();
                double length = c.Length;
                string sLength = $"{length / 100:F2}";
                
                Console.WriteLine(sLength);
            }
        }
    }
}