using System;

namespace _43
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num, total, cont, media;
            string texto;

            cont = 0;
            total = 0;

            while (cont < 10)

            {
            Console.WriteLine("Digite um número");
            texto = Console.ReadLine();
            num = int.Parse(texto);

            total = total + num;

            cont = cont + 1;
            }
            media = total / cont;

            Console.WriteLine("A media dos valores é: " + media);
        }
    }
}
