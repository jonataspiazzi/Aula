using System;

namespace _62
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int max, cont = 0;

            Console.WriteLine("Quantos numeros seram digítados?");
            max = int.Parse(Console.ReadLine());

            string[] num = new string[max];

            for (cont = 0; cont < max; cont++)
            
            {
                Console.WriteLine("Digíte o " + (cont + 1) + "º numero");
                num[cont] = Console.ReadLine();
            }

            int soma = 0;

            for (cont = 2; cont >= 0; cont--)
            {
                Console.WriteLine("O " + (soma + 1) + "º numero digitado foi: " + num[cont]);
                
                soma++;
            }

        }
    }
}
