using System;

namespace _77
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, cont = 0;

            Console.WriteLine("Quantos elementos vão ser digitados?");
            max = int.Parse(Console.ReadLine());

            int [] num = new int[max];

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero");
                num[cont] = int.Parse(Console.ReadLine());
            }

            int par = 0, impar = 0;

            for (cont = 0; cont < max; cont++)
            {
                if (num[cont] % 2 == 0)
                {
                    par += num[cont];
                }
                else 
                {
                    impar += num[cont];
                }
            }
            Console.WriteLine("A soma dos numeros par é: " + par);
            Console.WriteLine("A soma dos numeros impares é: " + impar);
        }
    }
}
