using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1040
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string[] grades = Console.ReadLine().Split(' ');
            double n1 = double.Parse(grades[0]) * 2;
            double n2 = double.Parse(grades[1]) * 3;
            double n3 = double.Parse(grades[2]) * 4;
            double n4 = double.Parse(grades[3]) * 1;
            double average = Math.Floor((n1 + n2 + n3 + n4)) / 10;

            Console.WriteLine($"Media: {average.ToString("F1", culture)}");

            if (average >= 7)
                Console.WriteLine("Aluno aprovado.");
            else if (average < 5)
                Console.WriteLine("Aluno reprovado.");
            else // 5 <= average < 7
            {
                double finalExam = double.Parse(Console.ReadLine(), culture);
                double result = (average + finalExam) / 2;

                Console.WriteLine("Aluno em exame.");
                Console.WriteLine($"Nota do exame: {finalExam.ToString("F1", culture)}");

                if (result >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {result.ToString("F1", culture)}");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {result.ToString("F1", culture)}");
                }
            }
        }
    }
}
