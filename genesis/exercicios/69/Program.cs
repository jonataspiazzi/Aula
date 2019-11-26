using System;

namespace _69
{
    class Program
    {
        static void Main(string[] args)
        {
           int max = 0, cont = 0;

            Console.WriteLine("Quantos elementos os vetores iram ter?");
            max = int.Parse(Console.ReadLine());

            int [] numA = new int [max];
            int [] numB = new int [max];
            int [] numC = new int [max];
            int [] numD = new int [max];

            while (cont < max)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero do vetor A");
                numA[cont] = int.Parse(Console.ReadLine());

                cont++;
            }

            cont = 0;

            while (cont < max)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero do vetor B");
                numB[cont] = int.Parse(Console.ReadLine());

                cont++;
            }

            cont = 0;

            while (cont < max)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero do vetor C");
                numC[cont] = int.Parse(Console.ReadLine());

                cont++;
            }

            cont = 0;

            while (cont < max)
            {
               numD[cont] = numA[cont] * numB[cont] - numC[cont];

                cont++;
            }

            cont = 0;

            while (cont < max)
            {
                Console.WriteLine("O valor do " + (cont + 1) + "º numero do vetor D é: " + numD[cont]);

                cont++;
            }
        }
    }
}
