using System;

namespace v3
{
    class Program
    {
        static void Main(string[] args)
        {
            // A versão 3 assume que o enunciado foi alterado para:

            // Construa um algoritmo que n valores inteiros (negativos ou positivos),
            // Imprima a soma dos valores absolutos.

            int num, qtd, soma;

            Console.Write("Digite a quantidade de números a serem lidos: ");
            qtd = int.Parse(Console.ReadLine());

            soma = 0;

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    num = -num;
                }

                soma += num;
            }

            Console.WriteLine("A soma dos valores absolutos é: " + soma);
        }
    }
}
