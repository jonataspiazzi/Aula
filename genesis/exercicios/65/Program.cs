using System;

namespace _65
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0, media, cont = 0;
            int menor = int.MaxValue, maior = int.MinValue;

            Console.WriteLine("Quantos numeros seram digitados?");
            int max = int.Parse(Console.ReadLine());

            int [] num = new int [max];

            while (cont < max)
            {
                Console.WriteLine("Digite o valor do " + (cont + 1) + " º numero");
                num[cont] = int.Parse(Console.ReadLine());

                total += num[cont];

                cont++;
            }
            cont = 0;
            while (cont < max)
            {
                if (num[cont] > maior)
                {
                    maior = num[cont];
                }
                if (num[cont] < menor)
                {
                    menor = num[cont];
                }
                cont++;
            }
            media = total / max;

            Console.WriteLine("O maior numero digitado foi: " + maior);
            Console.WriteLine("O menor numero digitado foi: " + menor);
            Console.WriteLine("A media dos numeros digitados é: " + media);
        }
    }
}
