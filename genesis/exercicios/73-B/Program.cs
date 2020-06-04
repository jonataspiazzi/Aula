using System;

namespace _73_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxA = 0, maxB = 0;
            int contA = 0, contB = 0;

            Console.WriteLine("Quantos elementos o vetor A ira ter?");
            maxA = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos elementos o vetor B ira ter?");
            maxB = int.Parse(Console.ReadLine());

            int [] numA = new int [maxA];

            for (contA = 0; contA < maxA; contA++)
            {
                Console.WriteLine("Digite o valor do " + (contA + 1) + "º numero do elemento A");
                numA[contA] = int.Parse(Console.ReadLine());
            }
            
            int [] numB = new int [maxB];

            for (contB = 0; contB < maxB; contB++)
            {
                Console.WriteLine("Digite o valor do " + (contB + 1) + "º numero do elemento B");
                numB[contB] = int.Parse(Console.ReadLine());
            }

            for (contA = 0; contA < maxA; contA++)
            {
                for(contB = 0;contB < maxB; contB++)
                {
                    if (numA[contA] == numB[contB])
                    {
                        Console.WriteLine("O " + (contA + 1) + "º numero do elemento A é o mesmo do " + (contB + 1) + "º do elemento B");
                    }
                }
            }
        }
    }
}
