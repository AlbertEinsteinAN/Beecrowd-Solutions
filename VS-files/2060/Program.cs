using System;

namespace Beecrowd
{
    class Problem2060
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] l = Console.ReadLine().Split();
            int[] values = new int[n];
            int m2 = 0, m3 = 0, m4 = 0, m5 = 0;

            for (int i = 0; i < n; i++)
                values[i] = int.Parse(l[i]);
            
            for (int i = 0; i < n; i++)
                if (values[i] % 2 == 0)
                    m2++;

            for (int i = 0; i < n; i++)
                if (values[i] % 3 == 0)
                    m3++;
            for (int i = 0; i < n; i++)
                if (values[i] % 4 == 0)
                    m4++;
            for (int i = 0; i < n; i++)
                if (values[i] % 5 == 0)
                    m5++;
            
            Console.WriteLine($"{m2} Multiplo(s) de 2");
            Console.WriteLine($"{m3} Multiplo(s) de 3");
            Console.WriteLine($"{m4} Multiplo(s) de 4");
            Console.WriteLine($"{m5} Multiplo(s) de 5");

        }
    }
}