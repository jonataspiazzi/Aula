using System;

namespace v5
{
    class Program
    {
        static void Main(string[] args)
        {
            // A versão 5 assume que o enunciado foi alterado para:

            // Construa um algoritmo que n valores inteiros (negativos ou positivos).
            // Ao final do programa, some os valores absolutos de cada número lido e
            // imprima o resultado da soma.
            // Deve ser usado vetor.
            // Deve ser usado funções.

            int qtd, soma;
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
                soma += Absoluto(nums[i]);
            }

            Console.WriteLine("A soma dos valores absolutos é: " + soma);
        }

        static int Absoluto(int num)
        {
            if (num < 0)
            {
                return -num;
            }
            else
            {
                return num;
            }
        }
    }
}
