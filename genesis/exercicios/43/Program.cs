using System;

namespace _43
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num, total = 0, cont = 1, media, maior = int.MinValue, menor = int.MaxValue;
            string texto;

            while (cont <= 10)
            {
            Console.WriteLine("Digite um número");
            texto = Console.ReadLine();
            num = int.Parse(texto);

             if (num < menor)
                {
                    menor = num;
                }
             else if (num > maior)
                {
                    maior = num;
                }   
             total += num; 

            cont++;
            }
            media = total / cont;

            Console.WriteLine("A media dos valores é: " + media);
            Console.WriteLine("O maior numero é: " + maior);
            Console.WriteLine("O menor numero é: " + menor);
        }
    }
}
