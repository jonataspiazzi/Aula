using System;

namespace Exercise28
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, qtd, cont, xr, xb, xc;

            // inicio

            Console.WriteLine("Digite a quantidade de vezes a executar:");
            qtd = int.Parse(Console.ReadLine());
            cont = 1;

            while (cont <= qtd)
            {
                Console.WriteLine("Digite um numero para fazer os calculos:");
                x = int.Parse(Console.ReadLine());

                xr = x % 5;
                Console.WriteLine("x % 5 = " + xr);

                xb = (int)Math.Pow(x, 2) + 20;
                Console.WriteLine("x ** 2 + 20 = " + xb);

                xc = (int)Math.Pow(x, 2) - x + 2;
                Console.WriteLine("x ** 2 - x + 2 = " + xc);

                cont++;
            }
        }
    }
}
