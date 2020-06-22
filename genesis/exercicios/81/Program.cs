using System;

namespace _81
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, max = 10;
            int [] num = new int [cont];

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero");
                num[cont] = int.Parse(Console.ReadLine());
            }

            Console.Write("A ordem dos numeros digitados é: ");

            for (cont = 0; cont < max; cont++)
            {
                Console.Write(num[cont]);
            }

            Console.Write("A ordem inversa dos numeros é:");

            for (cont = 0; cont < max; cont++)
            {
                num[cont] = num[cont + 10];
            }

            for (cont = 9; cont < max; cont--)
            {
                num[cont + 10] = num[cont];

            }

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine(" " + num[cont]);
            }
        }
    }
}
