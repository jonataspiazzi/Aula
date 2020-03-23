using System;

namespace TRIANGULO
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, cont2 = 1, caracter = 0, max = 0;

            Console.WriteLine("Qual o valor da base do triangulo?");
            max = int.Parse(Console.ReadLine());

            if (max % 2 == 0)
            {
                Console.WriteLine("Digite um valor impar");
            }
            else
            {
                for (cont = 0; cont < max; cont++)
                {
                    for(caracter = 0; caracter < cont2; caracter++)
                    {
                        Console.Write("* ");
                    }
                    cont2++;
                    Console.WriteLine("");
                }
            }

            

            
        }
    }
}
