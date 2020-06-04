using System;

namespace REQUISITO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int cont = 0, cont1 = 0, cont2 = 1, cont3 = 2;

            Console.WriteLine("Quantas pessoas vão fazer parte da escala?");
            max = int.Parse(Console.ReadLine());

            string [] nome = new string [max];

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º nome.");
                nome[cont] = Console.ReadLine();
            }
            for (cont = 0; cont < max; cont++)
            {  
                Console.WriteLine("O " + (cont1 + 1) + "º TRIO É: ");
                Console.WriteLine("O " + (cont1 + 1) + "º nome sorteado é: " + nome[cont1]);
                Console.WriteLine("O " + (cont1 + 1) + "º nome sorteado é: " + nome[cont2]);
                Console.WriteLine("O " + (cont1 + 1) + "º nome sorteado é: " + nome[cont3]);
                cont1++;
                cont2++;
                cont3++;
            }
        }
    }
}
