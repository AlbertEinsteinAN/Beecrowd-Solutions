using System;

namespace Beecrowd
{
    class Problem1960
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string romanNumeral = RomanConverter.ConvertToRoman(num);
            Console.WriteLine(romanNumeral);
        }
    }

    static class RomanConverter
    {
        public static string ConvertToRoman(int num)
        {
            string[] romanNumerals = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
            int[] values = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
            string roman = "";

            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    roman += romanNumerals[i];
                    num -= values[i];
                }
            }

            return roman;
        }
    }
}