using System;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero, soma, contNum, media, cont, max;
            string texto;

            soma = 0;
            contNum = 0;
            cont = 0;

            Console.WriteLine("Quantos numeros seram digitados?");
            texto = Console.ReadLine();
            max = int.Parse(texto);

            while (cont < max)
            {

            Console.WriteLine("Digite um numero");
            texto = Console.ReadLine();
            numero = int.Parse(texto);

            if (numero > 4)
            if (numero < 20)
            {
                soma = soma + numero;
                contNum = contNum + 1;
            }
            else
            {
            }
            cont = cont + 1;
            }
            media = soma / contNum;
            Console.WriteLine("A media dos numeros é " + media);
        }
    }
}
