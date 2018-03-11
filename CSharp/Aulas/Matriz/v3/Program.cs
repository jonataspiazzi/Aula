using System;

namespace Exercise52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double[,] notas;
            double media;
            string[] nomes;
            int qtdAlunos, qtdNota, contAluno, contNota;

            qtdNota = 3;

            Console.Write("Digite a quantidade de alunos: ");
            qtdAlunos = int.Parse(Console.ReadLine());
            
            notas = new double[qtdAlunos, qtdNota];
            nomes = new string[qtdAlunos];

            for (contAluno = 0; contAluno < qtdAlunos; contAluno++)
            {
                Console.Write("Digite o nome do aluno " + (contAluno + 1) + ": ");
                nomes[contAluno] = Console.ReadLine();

                for (contNota = 0; contNota < qtdNota; contNota++)
                {
                    Console.Write("Digite a " + (contNota + 1) + "ª nota do aluno " + (contAluno + 1) + ": ");
                    notas[contAluno, contNota] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("-----------");
            }

            contAluno = 0;
            while (contAluno < qtdAlunos)
            {
                media = (notas[contAluno, 0] * 2 + notas[contAluno, 1] * 3 + notas[contAluno, 2] * 5) / 10;
                Console.WriteLine("A média do aluno " + nomes[contAluno] + " é " + media);
                
                contAluno++;
            }
        }
    }
}
