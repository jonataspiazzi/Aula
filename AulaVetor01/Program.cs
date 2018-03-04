using System;

namespace AulaVetor01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3;
            int idade1, idade2, idade3;

            nome1 = Console.ReadLine();
            idade1 = int.Parse(Console.ReadLine());

            nome2 = Console.ReadLine();
            idade2 = int.Parse(Console.ReadLine());

            nome3 = Console.ReadLine();
            idade3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluno " + nome1 + " tem " + idade1 + " anos.");
            Console.WriteLine("Aluno " + nome2 + " tem " + idade2 + " anos.");
            Console.WriteLine("Aluno " + nome3 + " tem " + idade3 + " anos.");
        }
    }
}
