using System;

namespace Beecrowd
{
    class Problem1072
    {
        static void Main(string[] args)
        {
            int totalInputs = int.Parse(Console.ReadLine());
            int outValues = 0;
            int inValues = 0;
            int input = 0;

            if (totalInputs <= 0 && totalInputs > 10000)
            {
                return;
            }

            for (int i = 0; i < totalInputs; i++)
            {
                input = int.Parse(Console.ReadLine());
                
                if (input >= 10 && input <= 20)
                {
                    inValues++;
                }

                else
                {
                    outValues++;
                }
            }

            Console.WriteLine($"{inValues} in");
            Console.WriteLine($"{outValues} out");
        }
    }
}