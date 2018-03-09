using System;

namespace Exercise72
{
    class Program
    {
        static void Main(string[] args)
        {
            // Essa linha de baixo permite caracteres especiais no console
            // precisa executar só uma vez no programa inteiro.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] a; // fatorial existe somente de numeros inteiros.
            long[] b; 
            int i, num, qtd;
            long fatorial;

            qtd = 15;

            a = new int[qtd];
            b = new long[qtd];

            // Leitura de dados

            i = 0;
            while (i < qtd)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                a[i] = int.Parse(Console.ReadLine());
                i++;
            }

            // Processamento

            i = 0;
            while (i < qtd)
            {
                num = a[i];
                fatorial = 1; // qualquer número vezes 1 é 1.

                while (num > 0)
                {
                    fatorial = fatorial * num; // ou fatorial *= num;
                    num--;
                }

                b[i] = fatorial;
                i++;
            }

            // Apresentação

            i = 0;
            while (i < qtd)
            {
                Console.WriteLine(a[i] + "! = " + b[i]);
                i++;
            }
        }
    }
}
