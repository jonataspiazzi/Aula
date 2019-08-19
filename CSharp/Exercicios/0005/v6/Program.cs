using System;

namespace v6
{
    class Program
    {
        static void Main(string[] args)
        {
            // A versão 6 assume que o enunciado foi alterado para:

            // Construa um algoritmo que n valores inteiros (negativos ou positivos).
            // Ao final do programa, some os valores absolutos de cada número lido e
            // imprima o resultado da soma.
            // Deve ser usado vetor.
            // Deve ser usado funções.

            // A versão 6 difere da função 5, pois separa a leitura dos valores em uma outra função.

            int qtd, soma;
            int[] nums;
            
            Console.Write("Digite a quantidade de números a serem lidos: ");
            qtd = int.Parse(Console.ReadLine());

            nums = LeiaNumeros(qtd);

            soma = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                soma += Absoluto(nums[i]);
            }

            Console.WriteLine("A soma dos valores absolutos é: " + soma);
        }

        static int[] LeiaNumeros(int quantidade)
        {
            int[] nums = new int[quantidade];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            return nums;
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
