using System;

namespace Beecrowd
{
    class Problem1789
    {
        static void Main(string[] args)
        {
            string line;

            while ((line = Console.ReadLine()) != null)
            {
                int l = int.Parse(line), bigger = 0;
                int [] values = new int[l];
                string[] input = Console.ReadLine().Split(' ');

                for (int i = 0; i < l; i++)
                {
                    values[i] = int.Parse(input[i]);

                    if (values[i] > bigger)
                        bigger = values[i];
                }
                
                if (bigger < 10)
                    Console.WriteLine("1");
                else if (bigger >= 10 && bigger < 20)
                    Console.WriteLine("2");
                else
                    Console.WriteLine("3");
            }
        }
    }
}