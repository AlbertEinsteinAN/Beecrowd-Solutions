using System;

namespace Beecrowd
{
    class Problem1864
    {
        static void Main(string[] args)
        {
            string phrase = "LIFE IS NOT A PROBLEM TO BE SOLVED";
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= phrase.Length)
            {
                string output = phrase.Substring(0, n);
                Console.WriteLine(output);
            }

            else
            {
                Console.WriteLine("LIFE IS NOT A PROBLEM TO BE SOLVED");
            }
        }
    }
}