using System;

namespace v2
{
    class Program
    {
        static void Main(string[] args)
        {
            // A versão 2 assume que o enunciado foi alterado para:

            // Construa um algoritmo que leia 4 valores inteiros (negativos ou positivos),
            // Imprima a soma dos valores absolutos.

            int n1, n2, n3, n4, soma;

            Console.Write("Digite o número 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o número 2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o número 3: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Digite o número 4: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 < 0)
            {
                n1 = -n1;
            }

            if (n2 < 0)
            {
                n2 = -n2;
            }

            if (n3 < 0)
            {
                n3 = -n3;
            }

            if (n4 < 0)
            {
                n4 = -n4;
            }

            soma = n1 + n2 + n3 + n4;

            Console.WriteLine("A soma dos valores absolutos é: " + soma);
        }
    }
}
