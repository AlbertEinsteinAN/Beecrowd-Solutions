using System;

namespace Beecrowd
{
    class Problem1114
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x != 2002)
            {
                x = int.Parse(Console.ReadLine());
                if (x != 2002)
                {
                    Console.WriteLine("Senha Invalida");  
                }
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}