using System;

namespace _66
{
    class Program
    {
        static void Main(string[] args)
        {
            //NÃO TERMINEI

            decimal contA = 0, contB = 0, cont = 0, num;
            decimal [] grupoA = new decimal [5];
            decimal [] grupoB = new decimal [5];

            while (cont < 5)
            {
                Console.WriteLine("Digite o " (cont + 1) + "º do grupo A");
                grupoA[contA] = int.Parse(Console.ReadLine());

                cont++;
            }
            cont = 0;
            while (cont < 5)
            {
                Console.WriteLine("Digite o " (cont + 1) + "º do grupo B");
                grupoB[contB] = int.Parse(Console.ReadLine());

                cont++;
            }
            Console.WriteLine("Digite um numero");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(grupoA);
            Console.WriteLine(grupoB);
            Console.WriteLine(num);

            // NÃO TERMINEI
        }
    }
}
