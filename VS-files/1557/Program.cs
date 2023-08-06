using System;

class Program
{
    static void Main(string[] args)
    {
        int order;

        while ((order = int.Parse(Console.ReadLine())) != 0)
        {
            int[,] array = GeneratePowerArray(order);
            PrintFormattedArray(array);
            Console.WriteLine();
        }
    }

    static int[,] GeneratePowerArray(int order)
    {
        int[,] array = new int[order, order];

        for (int row = 0; row < order; row++)
        {
            for (int col = 0; col < order; col++)
            {
                array[row, col] = (int)Math.Pow(2, row + col);
            }
        }

        return array;
    }

    static void PrintFormattedArray(int[,] array)
    {
        int maxDigits = GetMaxDigits(array);

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                string formattedNumber = array[row, col].ToString().PadLeft(maxDigits);
                string separator = col == array.GetLength(1) - 1 ? "" : " ";
                Console.Write(formattedNumber + separator);
            }
            Console.WriteLine();
        }
    }

    static int GetMaxDigits(int[,] array)
    {
        int maxDigits = 0;

        foreach (int num in array)
        {
            int digits = (int)Math.Log10(num) + 1;
            if (digits > maxDigits)
            {
                maxDigits = digits;
            }
        }

        return maxDigits;
    }
}
