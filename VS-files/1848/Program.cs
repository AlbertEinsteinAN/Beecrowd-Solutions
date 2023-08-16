using System;

namespace Beecrowd
{
    class Program1848
    {
        static void Main(string[] args)
        {
            string[] blinkCombinations = { "--*", "-*-", "-**", "*--", "*-*", "**-", "***" };

            for (int i = 0; i < 3; i++)
            {
                int result = 0;

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "caw caw")
                        break;

                    result += Array.IndexOf(blinkCombinations, input) + 1;
                }

                Console.WriteLine(result);
            }
        }
    }
}
