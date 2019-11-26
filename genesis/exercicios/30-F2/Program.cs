using System;

namespace _30_F2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int largura = 52;
            int cont = 0;

            for (int altura = 5; cont < altura; cont++)

            {
                for (int caractere = 0; caractere < largura; caractere++)
                {
                    if (caractere < 18)
                    {
                        Console.Write("*");
                    }
                    else if (caractere < 35)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}
