using System;

namespace Exercise28v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, xr, xb, xc;
            ConsoleKey pergunta;

            // inicio

            pergunta = ConsoleKey.S;

            while (pergunta == ConsoleKey.S)
            {
                Console.WriteLine("Digite um numero para fazer os calculos:");
                x = int.Parse(Console.ReadLine());

                xr = x % 5;
                Console.WriteLine("x % 5 = " + xr);

                xb = (int)Math.Pow(x, 2) + 20;
                Console.WriteLine("x ** 2 + 20 = " + xb);

                xc = (int)Math.Pow(x, 2) - x + 2;
                Console.WriteLine("x ** 2 - x + 2 = " + xc);

                Console.WriteLine("Deseja calcular novamente? (s/n): ");
                pergunta = Console.ReadKey().Key;
                Console.WriteLine();
            }
        }
    }
}
