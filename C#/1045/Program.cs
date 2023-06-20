using System;

namespace Beecrowd
{
    class Problem1045
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            double n1 = double.Parse(input[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(input[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(input[2], CultureInfo.InvariantCulture);

            double a = Math.Max(Math.Max(n1, n2), n3);
            double c = Math.Min(Math.Min(n1, n2), n3);
            double b = 0;
            
            if (n1 != a && n1 != c)
            {
                b = n1;
            }
            else if (n2 != a && n2 != c)
            {
                b = n2;
            }
            else if (n3 != a && n3 != c)
            {
                b = n3;
            }
            else
            {
                b = Math.Min(Math.Min(n1, n2), n3);
            }

            double a2 = Math.Pow(a, 2);
            double b2 = Math.Pow(b, 2);
            double c2 = Math.Pow(c, 2);


            if (a == 0 || b == 0 || c == 0)
            {
                return;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            
            else
            {
                if (a2 == b2 + c2)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }

                else if (a2 > b2 + c2)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");              
                }
                
                else if (a2 < b2 + c2)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                else if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                
                else if ((a == b && b != c) || (a == c && c != b) || (c == b && b != a))
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            
        }
    }
}