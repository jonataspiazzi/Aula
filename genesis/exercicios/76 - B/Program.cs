using System;

namespace _76___B
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, cont = 0;
            string [] letra = new string [cont];

            Console.WriteLine("Quantas letras a palavra tem?");
            max = int.Parse(Console.ReadLine());

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite a " + (cont + 1) + "º letra da palavra");
                letra[cont] = Console.ReadLine());
            }

            int contMenos = max;

            string [] inverso = new string [contMenos];

            for (cont = 0; cont < max; cont++)
            {
                if (letra[cont] == inverso[contMenos])
                {
                    Console.WriteLine("A " + (cont + 1) + "º letra da palavra, é igual a " + (contMenos) + "º letra.");
                    contMenos--;
                }
                
            }
        }
    }
}
