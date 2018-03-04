using System;

namespace Exercise30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int qtdCarac, qtdLinha, qtdGlob;
            //string caractere = ((char)0x2588).ToString();
            string caractere = ((char)0x2592).ToString();
            ConsoleColor cor;

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
                    //caractere = "*";
                    cor = ConsoleColor.Blue;
                }
                else
                {
                    //caractere = "+";
                    cor = ConsoleColor.Red;
                }

                contLinha = 0;
                while (contLinha < qtdLinha)
                {
                    contCarac = 0;
                    while (contCarac < qtdCarac)
                    {
                        Console.ForegroundColor = cor;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(caractere);
                        contCarac++;
                    }
                    Console.WriteLine();
                    contLinha++;
                }
                contGlob++;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
