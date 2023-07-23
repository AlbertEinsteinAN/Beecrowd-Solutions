using System;
using System.Globalization;

namespace Beecrowd
{
    class Problem1118
    {
        static void Main(string[] args)
        {   
            double a = -1, b = -1, media = 0, answer = -1;
            CultureInfo culture = new CultureInfo("en-US");   

            a = -1;
            b = -1;

            while (a < 0 || a > 10)
            {
                a = double.Parse(Console.ReadLine());
                if (a < 0 || a > 10)
                    Console.WriteLine("nota invalida");
            }

            while (b < 0 || b > 10)
            {
                b = double.Parse(Console.ReadLine());
                if (b < 0 || b > 10)
                    Console.WriteLine("nota invalida");
            } 
            media = (a + b) / 2;
            Console.WriteLine($"media = {media.ToString("F2", culture)}");      
            
            while (true)
            {
                answer = -1;
                while (answer != 1 && answer != 2)                                  
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    answer = double.Parse(Console.ReadLine());
                }                
                if (answer == 1)
                {
                    a = -1;
                    b = -1;

                    while (a < 0 || a > 10)
                    {
                        a = double.Parse(Console.ReadLine());
                        if (a < 0 || a > 10)
                            Console.WriteLine("nota invalida");
                    }

                    while (b < 0 || b > 10)
                    {
                        b = double.Parse(Console.ReadLine());
                        if (b < 0 || b > 10)
                            Console.WriteLine("nota invalida");
                    } 
                    media = (a + b) / 2;
                    Console.WriteLine($"media = {media.ToString("F2", culture)}");
                }
                else if (answer == 2)
                    break;                
            }

            // Unfortunately this website doesnt support void functions like this:

            // static void checking()
            // {
            //     a = -1;
            //     b = -1;

            //     while (a < 0 || a > 10)
            //     {
            //         a = double.Parse(Console.ReadLine());
            //         if (a < 0 || a > 10)
            //             Console.WriteLine("nota invalida");
            //     }

            //     while (b < 0 || b > 10)
            //     {
            //         b = double.Parse(Console.ReadLine());
            //         if (b < 0 || b > 10)
            //             Console.WriteLine("nota invalida");
            //     } 
            //     media = (a + b) / 2;
            //     Console.WriteLine($"media = {media.ToString("F2", culture)}");                               
            // }
        }
    }
}