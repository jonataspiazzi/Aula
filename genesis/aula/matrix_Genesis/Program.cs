using System;

namespace MATRIX
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLinha = 0, maxColuna = 0;

            Console.WriteLine("Quantos caracteres cada linha deve ter?");
            maxLinha = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o total de linhas?");
            maxColuna = int.Parse(Console.ReadLine());

            int[,] num = new int[maxLinha,maxColuna];

            for (var contColuna = 0; contColuna < maxColuna; contColuna++)
            {
                for(var contLinha = 0; contLinha < maxLinha; contLinha++)
                {
                    Console.WriteLine("Digite um valor");
                    num[contLinha,contColuna] = int.Parse(Console.ReadLine());
                }
            }
            for (var contColuna = 0; contColuna < maxColuna; contColuna++)
            {
                for(var contLinha = 0; contLinha < maxLinha; contLinha++)
                {
                    Console.WriteLine("Na posição [" + contLinha + "," + contColuna + "] o numero digitado foi " + num[contLinha,contColuna]);
                }
            }
        }
    }
}
