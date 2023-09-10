using System;

namespace Beecrowd
{
    class Problem2061
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int tabs = 0; 
            string action;
            
            for (int i = 0; i < m; i++)
            {
                if ((action = Console.ReadLine()) == "fechou")
                    n++;
                else
                    n--;
            }
            
            Console.WriteLine(n);
        }
    }
}