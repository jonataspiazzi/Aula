using System;

namespace Exercise73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double[] a, b;
            int qtdA, qtdB, ia, ib;

            qtdA = 20;
            qtdB = 5;

            a = new double[qtdA];
            b = new double[qtdB];

            ia = 0;
            while (ia < qtdA)
            {
                Console.Write("Digite o " + (ia + 1) + "º elemento do vetor A: ");
                a[ia] = double.Parse(Console.ReadLine());
                ia++;
            }

            ib = 0;
            while (ib < qtdB)
            {
                Console.Write("Digite o " + (ib + 1) + "º elemento do vetor B: ");
                b[ib] = double.Parse(Console.ReadLine());
                ib++;
            }

            ia = 0;
            while (ia < qtdA)
            {
                ib = 0;
                while (ib < qtdB)
                {
                    if (a[ia] == b[ib])
                    {
                        Console.WriteLine("A na posição " + ia + " é igual a B na posição " + ib);
                    }

                    ib++;
                }

                ia++;
            }
        }
    }
}
