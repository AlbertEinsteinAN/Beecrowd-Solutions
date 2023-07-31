using System;

namespace Beecrowd
{
    class Problem1049
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();            

            if (input1 == "vertebrado")
            {
                if (input2 == "ave")
                {
                    if (input3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (input3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (input2 == "mamifero")
                {
                    if (input3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (input3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (input1 == "invertebrado")
            {
                if (input2 == "inseto")
                {
                    if (input3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (input3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (input2 == "anelideo")
                {
                    if (input3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (input3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
