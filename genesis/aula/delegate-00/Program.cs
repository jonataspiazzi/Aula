using System;

namespace delegate_00
{

    class Program
    {
        delegate bool DeterminadorDeDiagonal(int i, int j, int largura);

        ///delegate 
        static void Main(string[] args)
        {
            ImprimeDiagonal(10, 10, DiagonalDescendente);
        }

        static bool DiagonalAscendente(int i, int j, int largura)
        {
            return largura - i <= j;
        }

        static bool DiagonalDescendente(int i, int j, int largura)
        {
            return i < j;
        }

        static void ImprimeDiagonal(int altura, int largura, DeterminadorDeDiagonal determinante)
        {
            for (var j = 0; j < altura; j++)
            {
                for (var i = 0; i < largura; i++)
                {
                    if (determinante(i, j, largura))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("+");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
