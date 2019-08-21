using System;

namespace v4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enunciado do programa alterado para:

            // Escreva um algoritmo que imprima uma Tabuada escolhida pelo usuário. 

            Console.Write("Escolha a tabuada: ");
            int tab = int.Parse(Console.ReadLine());

            for (int num = 0; num <= 10; num++)
            {
                ImprimaLinhaTabuada(tab, num);
            }
        }

        static void ImprimaLinhaTabuada(int numeroTabuada, int linha)
        {
            int res = numeroTabuada * linha;

            Console.WriteLine(numeroTabuada + " X " + linha + " = " + res);
        }
    }
}
