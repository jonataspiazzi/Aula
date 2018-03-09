using System;

namespace AulaVetor02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome;
            int[] idade;
            
            nome = new string[3];
            idade = new int[3];

            nome[0] = Console.ReadLine();
            idade[0] = int.Parse(Console.ReadLine());

            nome[1] = Console.ReadLine();
            idade[1] = int.Parse(Console.ReadLine());

            nome[2] = Console.ReadLine();
            idade[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluno " + nome[0] + " tem " + idade[0] + " anos.");
            Console.WriteLine("Aluno " + nome[1] + " tem " + idade[1] + " anos.");
            Console.WriteLine("Aluno " + nome[2] + " tem " + idade[2] + " anos.");
        }
    }
}
