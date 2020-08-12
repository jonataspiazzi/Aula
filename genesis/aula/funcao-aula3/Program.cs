using System;

namespace funcao_aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();
            ImprimeDiagonal(30, 10, 0, 0, 1);
            //ImprimeDiagonal(20, 20, 20, 0, -1);
            //ImprimeDiagonal(20, 20, 0, 20, 1);
            //ImprimeDiagonal(20, 20, 20, 20, -1);
            Console.ResetColor();
            return;

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
            //EXPESSURA_DA_LINHA
            //expessura_da_linha
            //Expessura_Da_Linha

            //ExpessuraDaLinha
            //expessuraDaLinha
            //_ExpessuraDaLinha
            //_expessuraDaLinha

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

        static void ImprimeDesenho4(int altura, int largura, int espessuraDaLinha)
        {

        }

        static void ImprimeDiagonal(int altura, int largura, int x, int y, int diagonal)
        {
            for (var j = 0; j < altura; j++)
            {
                Console.SetCursorPosition(x, j + y);

                for (var i = 0; i < largura; i++)
                {
                    bool controle;

                    if (diagonal > 0)
                    {
                        controle = largura - i <= j;
                    }
                    else
                    {
                        controle = i < j;
                    }

                    if (controle)
                    {
                        ImprimeCaractere("*");
                    }
                    else
                    {
                        ImprimeCaractere("+");
                    }
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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Green;
            }

            Console.Write("▓");//█
        }
    }
}