using System;

namespace _71
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxA = 0, maxB = 0;
            int cont = 0;

            Console.WriteLine("Quantos elementos o vetor A tem?");
            maxA = int.Parse(Console.ReadLine());

            int [] numA = new int [maxA];

            for (cont = 0; cont < maxA; cont++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero.");
                numA[cont] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Quantos elementos o vetor B tem?");
            maxB = int.Parse(Console.ReadLine());

            for (cont = 0; cont < maxB; cont++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero.");
                numB[cont] = int.Parse(Console.ReadLine());
            }
        }
    }
}
