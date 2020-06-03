using System;

namespace sobe_desce
{
    class Program
    {
        // Faça um programa que imprima a tabela:
        //  V   H
        //  3  11
        //  5  10
        //  7   9
        //  9   8

        static void Main(string[] args)
        {
            Console.WriteLine("  V   H");

            /* V1
            for (int v = 3, h = 11; v <= 9 && h >= 8; v += 2, h--)
            {
                Console.WriteLine("  " + v + "  " + h);
            }
            */

            // Para simplificar usar a lógica de PA (ou PG)
            // Numero (N) = ValorInicial + ConstanteDeMudanca * N

            for (int pivo = 0; pivo < 4; pivo++)
            {
                int v = 3 + 2 * pivo;
                int h = 11 + (-1) * pivo;

                Console.WriteLine("  " + v + "  " + h);
            }
        }
    }
}
