using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

            Console.Write("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            double[] numeros = new double[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            ImprimaAbsoluto(numeros, quantidade);
            double media = CalculaMedia(numeros, quantidade);
            int qtdNegativo = ContaNegativos(numeros, quantidade);

            Console.WriteLine($"A média dos números entre -8 e 10 é: {media}");
            Console.WriteLine($"A quantidade de negativos é: {qtdNegativo}");
        }

        static void ImprimaAbsoluto(double[] numeros, int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                double abs;

                if (numeros[i] < 0)
                {
                    abs = -numeros[i];
                }
                else
                {
                    abs = numeros[i];
                }

                Console.WriteLine($"O valor absoluto de {numeros[i]} é {abs}");
            }
        }

        static double CalculaMedia(double[] numeros, int quantidade)
        {
            double soma = 0;
            int qtd = 0;

            for (int i = 0; i < quantidade; i++)
            {
                if (numeros[i] >= -8 && numeros[i] <= 10)
                {
                    qtd++;
                    soma += numeros[i];
                }
            }

            double media = soma / qtd;

            return media;
        }

        static int ContaNegativos(double[] numeros, int quantidade)
        {
            int qtd = 0;

            for (int i = 0; i < quantidade; i++)
            {
                if (numeros[i] < 0)
                {
                    qtd++;
                }
            }

            return qtd;
        }
    }
}
