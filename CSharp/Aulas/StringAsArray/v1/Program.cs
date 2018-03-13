using System;

namespace v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("--------");

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("A " + (i + 1) + "ª letra do seu nome é: " + nome[i]);
            }
        }
    }
}
