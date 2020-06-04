using System;

namespace _76
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            Console.WriteLine("Quantos caracteres o seu palíndromo tem?");
            int max = int.Parse(Console.ReadLine());

            string [] caractere = new string [max];

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + " º caracteres da palavra");
                caractere[cont] = Console.ReadLine();
            }

            int inverso = cont;

            for (cont = 0; cont < max; cont++)
            {
                if (caractere[cont] == caractere[inverso])
                {
                   Console.WriteLine("O " + (cont + 1) + "º caractere e o " + (inverso + 1) + "º caractere são iguais");
                }
                Console.WriteLine("O " + (cont + 1) + "º caractere e o " + (inverso + 1) + "º caractere não são iguais");
                inverso--;
            }
        }
    }
}
