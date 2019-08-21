using System;

namespace v5
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
                string linha = GerarLinhaTabuada(tab, num);

                Console.WriteLine(linha);
            }
        }

        static string GerarLinhaTabuada(int numTabuada, int linha)
        {
            int res = numTabuada * linha;

            return numTabuada + " X " + linha + " = " + res;
        }
    }
}
