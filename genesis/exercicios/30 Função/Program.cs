using System;

namespace _30_Função
{
    class Program
    {
        static void Main(string[] args)
        {
            var escolhaDesenho = LeiaInteiro("Qual desenho você deseja ver?");
            var maxLinha = LeiaInteiro("Qual a altura do desenho?");
            var maxLargura = LeiaInteiro("Quantos caracteres a linha deve ter?");
            string D1 = LeiaString("Qual caracter você deseja usar na primira posição?");
            string D2 = LeiaString("Qual caracter você deseja usar na segunda posição?");

            if (escolhaDesenho == 1)
            {
                DesenhoUm(maxLinha, D1, D2, maxLargura);
            }
            else if (escolhaDesenho == 2)
            {
                DesenhoDois(maxLinha, maxLargura, D1, D2);
            }
            else if (escolhaDesenho == 3)
            {
                DesenhoTres(maxLinha, maxLargura, D1, D2);
            }
            else if (escolhaDesenho == 4)
            {
                DesenhoQuatro(maxLargura, maxLinha, D1, D2);
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Escolha um numero entre 1 e 4");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        static int LeiaInteiro(string mensagem)
        {
            Console.WriteLine(mensagem);
            return int.Parse(Console.ReadLine());
        }
        static string LeiaString(string mensagem)
        {
            Console.WriteLine(mensagem);
            return Console.ReadLine();
        }
        static void LinhaCaracter(string caracter, int maxLargura) 
        {
            for (var contC = 0; contC < maxLargura; contC++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine();
        }
        static void DesenhoUm(int maxLinha, string D1, string D2, int maxLargura)
        {
           for (var cont = 0; cont < maxLinha; cont++)
           {
               string caracter = D1;
               if (cont == 2 || cont == 3)
               {
                caracter = D2;
               }
               LinhaCaracter(caracter, maxLargura);
           }
        }
        static void DesenhoDois(int maxLinha, int maxLargura, string D1, string D2)
        {
            for (var cont = 0; cont < maxLinha; cont++)
            {
                var a = maxLargura / 3;

                for(var contLar = 0; contLar < maxLargura; contLar++)
                {
                    if (contLar <= a || contLar >= a + a)
                    {
                        Console.Write(D1);
                    }
                    else
                    {
                        Console.Write(D2);
                    }
                }
                Console.WriteLine();
            }
        }
        static void DesenhoTres(int maxLinha, int maxLargura, string D1, string D2)
        {
            var a = 0;
            for (var cont = 0; cont < maxLinha; cont++)
            {
                for(var contLar = 0; contLar < maxLargura; contLar++)
                {
                   if (contLar <= a)
                   {
                       Console.Write(D1);
                   }
                   else
                   {
                       Console.Write(D2);
                   }
                }
                Console.WriteLine();
                a++;
            }
        }
        static void DesenhoQuatro(int maxLargura, int maxLinha, string D1, string D2)
        {
            int a = maxLargura, b = 0, c = maxLargura / 2;
            for (var cont = 0; cont < maxLinha; cont++)
            {
                for(var contLar = 0; contLar < maxLargura; contLar++)
                {
                    if (contLar < a)
                    {
                        Console.Write(D1);
                    }
                    else
                    {
                        Console.Write(D2);
                    }
                }
                for(var contLar = 0; contLar < maxLargura; contLar++)
                {
                    if (b > contLar)
                    {
                        Console.Write(D2);
                    }
                    else
                    {
                        Console.Write(D1);
                    }
                }
                a--; b++;
                Console.WriteLine();
            }
        }
    }
}
