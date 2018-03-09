using System;

namespace Exercise52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double[] n1, n2, n3;
            double media;
            string[] nomes;
            int qtdAlunos, i;

            Console.Write("Digite a quantidade de alunos: ");
            qtdAlunos = int.Parse(Console.ReadLine());
            
            n1 = new double[qtdAlunos];
            n2 = new double[qtdAlunos];
            n3 = new double[qtdAlunos];
            nomes = new string[qtdAlunos];

            i = 0;
            while (i < qtdAlunos)
            {
                Console.Write("Digite o nome do aluno " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine();

                Console.Write("Digite a 1ª nota do aluno " + (i + 1) + ": ");
                n1[i] = double.Parse(Console.ReadLine());
                
                Console.Write("Digite a 2ª nota do aluno " + (i + 1) + ": ");
                n2[i] = double.Parse(Console.ReadLine());
                
                Console.Write("Digite a 3ª nota do aluno " + (i + 1) + ": ");
                n3[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("-----------");
                i++;
            }

            i = 0;
            while (i < qtdAlunos)
            {
                media = (n1[i] * 2 + n2[i] * 3 + n3[i] * 5) / 10;
                Console.WriteLine("A média do aluno " + nomes[i] + " é " + media);
                
                i++;
            }
        }
    }
}
