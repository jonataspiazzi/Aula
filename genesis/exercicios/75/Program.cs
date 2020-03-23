using System;

namespace _75
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guardando os elementos dos vetores.

            Console.WriteLine("Quantos elementos os vetores teram?");
            int max = int.Parse(Console.ReadLine());

            int [] numA = new int[max];
            int [] numB = new int[max];

            int cont = 0;

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + " º numero do vetor A");
                numA[cont] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o " + (cont + 1) + " º numero do vetor B");
                numB[cont] = int.Parse(Console.ReadLine());
            }
            int menorA = int.MaxValue, menorB = int.MaxValue;
            int maiorA = int.MinValue, maiorB = int.MinValue;

            for (cont = 0; cont < max; cont++)
            {
                if (numA[cont] < menorA)
                {
                    menorA = numA[cont];
                }
                else if (numA[cont] > maiorA)
                {
                    maiorA = numA[cont];
                }
                 if (numB[cont] < menorB)
                {
                    menorB = numB[cont];
                }
                else if (numB[cont] > maiorB)
                {
                    maiorB = numB[cont];
                }
            }

            Console.WriteLine("O maior numero do vetor A é: " + maiorA);
            Console.WriteLine("O menor numero do vetor A é: " + menorA);
            Console.WriteLine("O maior numero do vetor B é: " + maiorB);
            Console.WriteLine("O menor numero do vetor B é: " + menorB);

            if (maiorA > maiorB)
            {
                Console.WriteLine("O maior numero entre o vetor A e B é: " + maiorA);
            }
            else if (maiorB > maiorA)
            {
                Console.WriteLine("O maior numero entre o vetor A e B é " + maiorB);
            }
            if (menorA < menorB)
            {
                Console.WriteLine("O menor numero entre o vetor A e B é: " + menorA);
            }
            else if (menorB < menorA)
            {
                Console.WriteLine("O menor numero entre o vetor A e B é " + menorB);
            }
        }
    }
}
