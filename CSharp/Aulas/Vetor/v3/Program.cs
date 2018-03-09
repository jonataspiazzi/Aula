using System;

namespace AulaVetor03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome;
            int[] idade;
            int qtd, cont;

            Console.WriteLine("Digite a quantidade de alunos: ");
            qtd = int.Parse(Console.ReadLine());
            
            nome = new string[qtd];
            idade = new int[qtd];

            cont = 0;
            while (cont < qtd)
            {
                Console.WriteLine("Digite o nome do aluno " + (cont + 1) + ":");
                nome[cont] = Console.ReadLine();
                Console.WriteLine("Digite a idade do aluno " + (cont + 1) + ":");
                idade[cont] = int.Parse(Console.ReadLine());
                cont++;
            }

            cont = 0;
            while (cont < qtd)
            {
                Console.WriteLine("Aluno " + nome[cont] + " tem " + idade[cont] + " anos.");
                cont++;
            }
        }
    }
}
