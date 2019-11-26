using System;

namespace _68
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
                numC[cont] = numA[cont] - numB[cont];

                cont++;
            }

            cont = 0;

            while (cont < max)
            {
                Console.WriteLine("O valor do " + (cont + 1) + "º numero do vetor A é: " + numA[cont]);
                Console.WriteLine("O valor do " + (cont + 1) + "º numero do vetor B é: " + numB[cont]);
                Console.WriteLine("O valor do " + (cont + 1) + "º numero do vetor C é: " + numC[cont]);

                cont++;
            }
        }
    }
}
