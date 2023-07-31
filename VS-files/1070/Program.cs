using System;

namespace Beecrowd
{
    class Problem1070
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                return;
            }

            if (x % 2 == 0)
            {
                x += 1;
                Console.WriteLine(x);
                x += 2;
                Console.WriteLine(x);               
                x += 2;
                Console.WriteLine(x);
                x += 2;
                Console.WriteLine(x);  
                x += 2;
                Console.WriteLine(x);
                x += 2;
                Console.WriteLine(x);              
            }

            else
            {           
                Console.WriteLine(x);
                x += 2;
                Console.WriteLine(x);  
                x += 2;
                Console.WriteLine(x);
                x += 2;
                Console.WriteLine(x);
                x += 2;
                Console.WriteLine(x); 
                x += 2;
                Console.WriteLine(x);    
            }
        }
    }
}