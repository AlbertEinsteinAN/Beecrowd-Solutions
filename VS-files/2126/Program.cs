using System;

namespace Beecrowd
{
    class Problem2126
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            string sb_str, str;
            
            while ((sb_str = Console.ReadLine()) != null)
            {
                str = Console.ReadLine();

                int total = 0, pos = 0;
                int sb_lnth = sb_str.Length, str_lnth = str.Length;

                for (int i = 0; i <= str_lnth - sb_lnth; i++)
                {
                    if (str[i] == sb_str[0])
                    {
                        int cnt2 = 1, tmp = i + 1;
                        for (int k = i + 1, l = 1; l < sb_lnth; l++, k++)
                        {
                            if (str[k] == sb_str[l])
                            {
                                cnt2++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (cnt2 == sb_lnth)
                        {
                            total++;
                            pos = tmp;
                        }
                    }
                }

                Console.WriteLine($"Caso #{++cnt}:");

                if (total == 0)
                {
                    Console.WriteLine("Nao existe subsequencia\n");
                }
                else
                {
                    Console.WriteLine($"Qtd.Subsequencias: {total}");
                    Console.WriteLine($"Pos: {pos}\n");
                }
            }
        }
    }
}
