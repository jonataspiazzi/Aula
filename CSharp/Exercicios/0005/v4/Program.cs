using System;

namespace v4
{
    class Program
    {
        static void Main(string[] args)
        {
            // A versão 4 assume que o enunciado foi alterado para:

            // Construa um algoritmo que n valores inteiros (negativos ou positivos).
            // Ao final do programa, some os valores absolutos de cada número lido e
            // imprima o resultado da soma.
            // Deve ser usado vetor.

            int qtd, soma, abs;
            int[] nums;

            Console.Write("Digite a quantidade de números a serem lidos: ");
            qtd = int.Parse(Console.ReadLine());

            nums = new int[qtd];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            soma = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    abs = -nums[i];
                }
                else
                {
                    abs= nums[i];
                }

                soma += abs;
            }

            Console.WriteLine("A soma dos valores absolutos é: " + soma);
        }
    }
}
