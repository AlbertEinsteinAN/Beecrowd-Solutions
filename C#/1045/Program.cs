using System;

namespace Beecrowd
{
    class Problem1045
    {
        static void Main()
        {
            double a, b, c, maior, menor, meio;
            string[] inputs = Console.ReadLine().Split(' ');
            a = double.Parse(inputs[0]);
            b = double.Parse(inputs[1]);
            c = double.Parse(inputs[2]);

            if (a >= b && a >= c)
            {
                maior = a;
                meio = b;
                menor = c;
            }
            else if (b >= a && b >= c)
            {
                maior = b;
                meio = a;
                menor = c;
            }
            else
            {
                maior = c;
                meio = a;
                menor = b;
            }

            if (maior >= meio + menor)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (maior * maior == meio * meio + menor * menor)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (maior * maior > meio * meio + menor * menor)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (maior * maior < meio * meio + menor * menor)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (maior == meio && maior == menor)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                if (maior == meio && maior != menor && menor != meio)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                if (meio == menor && maior != meio && maior != menor)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                if (maior == menor && menor != meio && maior != meio)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}