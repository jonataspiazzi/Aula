using System;

namespace CHUVA
{
    class Program
    {
        static void Main(string[] args)
        {
           int max = 0, dist = 0, cont = 0, cont2 = 0;
            int um = 0;

            Console.WriteLine("Digite um número de caracteres.");
            max = int.Parse(Console.ReadLine());

            for (cont = 0; cont < max; cont++)
            {
                for (cont2 = 0; cont2 < cont; cont2++)
                {
                    Console.Write("*");
                    for (um = 0; um < cont; um++)
                    {
                        Console.Write(" ");
                    }
                    um = 0;
                }
                Console.WriteLine("");
            }
        }
        
    }
}
