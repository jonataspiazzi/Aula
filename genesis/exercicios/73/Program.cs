using System;

namespace _73
{
    class Program
    {
        static void Main(string[] args)
        {
            // Armazenando os elementos do vetor A e B.

            int maxA = 0, maxB = 0;
            int cont = 0, contA = 0, contB = 0;

            Console.WriteLine("Quantos elementos o vetor A ira ter?");
            maxA = int.Parse(Console.ReadLine());

            int [] numA = new int [maxA];

            for (contA = 0; contA < maxA; contA++)
            {
               Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero do elemento A");
               numA[contA] = int.Parse(Console.ReadLine());
               contA++;
               cont++;
            }
            contA = 0;
            cont = 0;

            Console.WriteLine("Quantos elementos o vetor B ira ter?");
            maxB = int.Parse(Console.ReadLine());

            int [] numB = new int [maxB];

            for (contB = 0; contB < maxB; contB++)
            {
                Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero do elemento B");
                numB[contB] = int.Parse(Console.ReadLine());
                contB++;
                cont++;
            }
            contB = 0;
            cont = 0;

            //Comparando os elementos

            string repetidos;

            for (cont = 0; contA < maxA; cont++)
            {
                for (cont = 0; contB < maxB; contB++)
                {
                    if (numA[contA] == numB[contB])
                    {
                        repetidos = numA[contA] + " /";
                    }  
                }
                contA++;
            }
        }
    }
}
