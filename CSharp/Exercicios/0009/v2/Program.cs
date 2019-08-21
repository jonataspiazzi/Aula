using System;

namespace v2
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
                int res = num * tab;

                Console.WriteLine(tab + " X " + num + " = " + res);
            }
        }
    }
}
