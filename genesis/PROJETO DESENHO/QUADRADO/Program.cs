using System;

namespace QUADRADO
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, cont2 = 0, max = 0;

            Console.WriteLine("Quantos caracteres os lados do quadrado deve ter?");
            max = int.Parse(Console.ReadLine());
            

            for(cont = 0; cont < max; cont++)
            {
                for (cont2 = 0; cont2 < max; cont2++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
