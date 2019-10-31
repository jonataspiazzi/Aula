using System;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero, soma = 0, contNum = 0, media, cont = 0, max, menor = int.MaxValue;
            string texto;

            Console.WriteLine("Quantos numeros seram digitados?");
            texto = Console.ReadLine();
            max = int.Parse(texto);

            while (cont < max)
            {

            Console.WriteLine("Digite um numero");
            texto = Console.ReadLine();
            numero = int.Parse(texto);

            if (numero < menor)
              {
                menor = numero;
              }

            if (numero > 4)
            if (numero < 20)
              {
                soma += numero;
                contNum = contNum + 1;
              }
            cont++;
            }
            media = soma / contNum;
            Console.WriteLine("A media dos numeros é " + media);
            Console.WriteLine("O menor numero é: " + menor);
        }
    }
}
