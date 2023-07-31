using System;

namespace Beecrowd
{
    class Problem1131
    {
        static void Main(string[] args)
        {
            int answer = 0, inter = 0, gremio = 0, vI = 0, vG = 0, draw = 0, grenais = 0;
            string[] scores = new string[2];            

            while (true)
            {
                answer = 0;

                scores = Console.ReadLine().Split(' ');
                inter = int.Parse(scores[0]);
                gremio = int.Parse(scores[1]);

                if (gremio > inter)
                    vG++;
                else if (inter > gremio)
                    vI++;
                else draw++;

                grenais++;

                while (answer != 1 && answer != 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    answer = int.Parse(Console.ReadLine());                                  
                }
                if (answer == 2)
                        break;
            }
            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter:{vI}");
            Console.WriteLine($"Gremio:{vG}");
            Console.WriteLine($"Empates:{draw}");
            if (vI > vG)
                Console.WriteLine("Inter venceu mais");
            else if (vG > vI)
                Console.WriteLine("Gremio venceu mais");
        }
    }
}