using System;

namespace Exercise52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double[,] n;
            double media;
            string[] nomes;
            int qtdAlunos, i;

            Console.Write("Digite a quantidade de alunos: ");
            qtdAlunos = int.Parse(Console.ReadLine());
            
            n = new double[qtdAlunos, 3];
            nomes = new string[qtdAlunos];

            i = 0;
            while (i < qtdAlunos)
            {
                Console.Write("Digite o nome do aluno " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine();

                Console.Write("Digite a 1ª nota do aluno " + (i + 1) + ": ");
                n[i, 0] = double.Parse(Console.ReadLine());
                
                Console.Write("Digite a 2ª nota do aluno " + (i + 1) + ": ");
                n[i, 1] = double.Parse(Console.ReadLine());
                
                Console.Write("Digite a 3ª nota do aluno " + (i + 1) + ": ");
                n[i, 2] = double.Parse(Console.ReadLine());

                Console.WriteLine("-----------");
                i++;
            }

            i = 0;
            while (i < qtdAlunos)
            {
                media = (n[i, 0] * 2 + n[i, 1] * 3 + n[i, 2] * 5) / 10;
                Console.WriteLine("A média do aluno " + nomes[i] + " é " + media);
                
                i++;
            }
        }
    }
}
