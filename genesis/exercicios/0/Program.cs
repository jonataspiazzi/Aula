using System;

namespace _0
{
    class Program
    {
        static void Main(string[] args)
        {
            const int largura = 52;
            int altura = 5;

            for (int cont = 0; cont < altura; cont++)
            {
                for (int caractere = 0; caractere < largura; caractere++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
