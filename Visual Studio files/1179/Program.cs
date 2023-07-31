using System;
using System.Collections.Generic;

namespace Beecrowd
{
    class Problem1179
    {
        static void Main(string[] args)
        {
            List<int> evenList = new List<int>(), oddList = new List<int>();

            for (int i = 0; i < 15; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    if (evenList.Count < 5)
                        evenList.Add(input);
                    else
                    {
                        PrintArray("par", evenList);
                        evenList.Clear();
                        evenList.Add(input);
                    }
                }
                else
                {
                    if (oddList.Count < 5)
                        oddList.Add(input);
                    else
                    {
                        PrintArray("impar", oddList);
                        oddList.Clear();
                        oddList.Add(input);
                    }
                }
            }

            PrintArray("impar", oddList);
            PrintArray("par", evenList);
        }

        static void PrintArray(string label, List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
                Console.WriteLine($"{label}[{i}] = {array[i]}");
        }
    }
}