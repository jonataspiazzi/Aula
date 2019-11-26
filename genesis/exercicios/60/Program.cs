using System;

namespace _60
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, cont = 0;

            Console.WriteLine("Quantos numeros seram digítados?");
            max = int.Parse(Console.ReadLine());

            int[] num = new int[max];

            while (cont < max)
            {
                Console.WriteLine("Digíte o " + (cont + 1) + "º numero");
                num[cont] = int.Parse(Console.ReadLine());

                cont++;
            }

            cont = 0;

            while (cont < max)
            {   
                int numero;
                numero = num[cont];
                Console.WriteLine("O " + (cont + 1) + "º numero digitado foi: " + numero);
                cont++;
            }

            
        }
    }
}
