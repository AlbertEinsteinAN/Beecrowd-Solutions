using System;

namespace Beecrowd
{
    class Problem1984
    {
        static void Main(string[] args)
        {
            char[] num = Console.ReadLine().ToCharArray();
            int lnth = num.Length;
            int i, j;
            char temp;

            for (i = 0, j = lnth - 1; i < lnth / 2; i++, j--)
            {
                temp = num[i];
                num[i] = num[j];
                num[j] = temp;
            }

            Console.WriteLine(new string(num));
        }
    }
}