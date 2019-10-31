using System;

namespace _45
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal max, cont = 0, codprod, qtdest, qtdmax, qtdmin, qtcomprar;

            Console.WriteLine("Quantos produtos seram analisados?");
            max = int.Parse(Console.ReadLine());

            while (cont < max)
            {
                Console.WriteLine("Qual o código do produto?");
                codprod = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a quantidade mínima do produto?");
                qtdmin = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a quantidade máxima do produto?");
                qtdmax = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a quantidade em estoque?");
                qtdest = int.Parse(Console.ReadLine());

                if (qtdest <= qtdmin)
                {
                    qtcomprar = qtdmax - qtdest;
                    Console.WriteLine("É preciso comprar " + qtcomprar + " do produto: " + codprod);
                }
                cont++;
            }
        }
    }
}
