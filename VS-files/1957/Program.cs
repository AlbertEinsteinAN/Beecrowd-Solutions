using System;

namespace Beecrowd
{
    class Problem1957
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexadecimalNumber = DecimalToHexadecimal(decimalNumber);

            Console.WriteLine(hexadecimalNumber);
        }

        static string DecimalToHexadecimal(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";

            char[] hexDigits = "0123456789ABCDEF".ToCharArray();
            string hexadecimalNumber = "";

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 16;
                hexadecimalNumber = hexDigits[remainder] + hexadecimalNumber;
                decimalNumber /= 16;
            }

            return hexadecimalNumber;
        }
    }
}