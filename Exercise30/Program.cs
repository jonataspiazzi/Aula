using System;

namespace Exercise30
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdCarac, qtdLinha, qtdGlob;
            string caractere;

            Console.WriteLine("Digite a largura: ");
            qtdCarac = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura da linha: ");
            qtdLinha = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do desenho: ");
            qtdGlob = int.Parse(Console.ReadLine());

            qtdGlob = qtdGlob / qtdLinha;

            int contCarac, contLinha, contGlob;

            contGlob = 0;
            while (contGlob < qtdGlob)
            {
                if (contGlob % 2 == 0)
                {
                    caractere = "*";
                }
                else
                {
                    caractere = "+";
                }

                contLinha = 0;
                while (contLinha < qtdLinha)
                {
                    contCarac = 0;
                    while (contCarac < qtdCarac)
                    {
                        Console.Write(caractere);
                        contCarac++;
                    }
                    Console.WriteLine();
                    contLinha++;
                }
                contGlob++;
            }
        }
    }
}
