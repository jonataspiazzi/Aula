using System;

namespace _71
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxA = 0, maxB = 0;
            int cont = 0, contA = 0, contB = 0;

            Console.WriteLine("Quantos elementos o vetor A tem?");
            maxA = int.Parse(Console.ReadLine());

            int[] numA = new int[maxA];

            for (contA = 0; contA < maxA; contA++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero.");
                numA[contA] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Quantos elementos o vetor B tem?");
            maxB = int.Parse(Console.ReadLine());

            int[] numB = new int[maxB];

            for (contB = 0; contB < maxB; contB++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero.");
                numB[contB] = int.Parse(Console.ReadLine());
            }

            int maxT;
            maxT = maxA + maxB;
            contA = 0;
            contB = 0;

            Console.WriteLine("A sequencia de numeros do vetor C é: ");

            for (cont = 0; cont < maxT; cont++)
            {
                while (cont < maxA)
                {
                    Console.Write(numA[contA] + " / ");
                    contA++;
                    cont++;
                }

                Console.Write(numB[contB] + " / ");
                contB++;

            }
        }
    }
}
