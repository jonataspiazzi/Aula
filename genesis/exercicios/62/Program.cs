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

            while (cont < max)
            
            {
                Console.WriteLine("Digíte o " + (cont + 1) + "º numero");
                num[cont] = Console.ReadLine();

                cont++;
            }

            while (cont > 0)

            {
                Console.WriteLine("O " + cont + "º numero digitado foi: " + num[cont]);

                cont--;
            }

        }
    }
}
