using System;

namespace funcao_aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            var desenho = LeiaInteiro("Digite o número do desenho que você deseja ver: ");
            var altura = LeiaInteiro("Digite a altura do desenho que você deseja ver: ");
            var largura = LeiaInteiro("Digite a largura do desenho que você deseja ver: ");

            if (desenho == 1)
            {
                ImprimeDesenho1(altura, largura, 2);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static int LeiaInteiro(string mensagem)
        {
            Console.WriteLine(mensagem);

            return int.Parse(Console.ReadLine());
        }

        static void ImprimeDesenho1(int altura, int largura, int espessuraDaLinha)
        {
            var caractere = "*";
            var linha = 0;

            while (true)
            {
                for (var i = 0; i < espessuraDaLinha; i++)
                {
                    ImprimeLinha(caractere, largura);

                    if (linha >= altura) return;

                    linha++;
                }

                if (caractere == "*")
                {
                    caractere = "+";
                }
                else
                {
                    caractere = "*";
                }
            }
        }

        static void ImprimeLinha(string caractere, int comprimentoDaLinha)
        {
            for (var i = 0; i < comprimentoDaLinha; i++)
            {
                ImprimeCaractere(caractere);
            }

            Console.WriteLine();
        }

        static void ImprimeCaractere(string caractere)
        {
            if (caractere == "*")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Red;
            }

            Console.Write("▓");//█
        }
    }
}