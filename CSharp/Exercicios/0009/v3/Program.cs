using System;

namespace v3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enunciado do programa alterado para:

            // Escreva um algoritmo que imprima uma Tabuada escolhida pelo usuário. 

            Console.Write("Escolha a tabuada: ");
            int tab = int.Parse(Console.ReadLine());

            ImprimaTabuada(tab);
        }

        static void ImprimaTabuada(int doNum)
        {
            for (int num = 0; num <= 10; num++)
            {
                int res = num * doNum;

                Console.WriteLine(doNum + " X " + num + " = " + res);
            }
        }
    }
}
