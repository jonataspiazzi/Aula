using System;

namespace _30_F1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int largura = 52;

            int caractere = 0;

            while (caractere < largura)
            {
                Console.Write("*");
                caractere++;
            }

            /*
            for (int caractere = 0; caractere < largura; caractere++)
            {
                Console.Write("*");
            }
            */

            Console.WriteLine();
        }
    }
}
