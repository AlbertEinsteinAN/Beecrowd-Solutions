using System;

namespace Beecrowd
{
    class Problem1146
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x != 0)
            {
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                    break;

                int count = 1;
                int[] values = new int[x];                

                for (int i = 0; i < x; i++)
                {
                    values[i] = count;
                    count++;
                }           

                // you can use the string.Join() method to join the elements of the array with a space delimiter 
                // and then trim any leading or trailing whitespace using the Trim() method.
                string output = string.Join(" ", values).Trim(); 
                Console.WriteLine(output);
            }
        }
    }
}