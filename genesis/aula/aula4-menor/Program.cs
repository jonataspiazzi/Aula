using System;

namespace aula4_menor
{
    class Program
    {
        // Faça um programa que leia N número e apresente o menor número lido.

        static void Main(string[] args)
        {
            int numero = 0, quantidade = 0, cont = 0, menor = int.MaxValue;

            Console.Write("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            while (cont < quantidade)
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < menor)
                {
                    menor = numero;
                }

                cont++; // soma += numero;
            }

            Console.Write("O menor número digitado é " + menor);
        }
    }
}
