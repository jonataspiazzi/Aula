using System;

namespace _58
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal max = 0, cont = 0, codigo = 0, valor = 0, aumento = 0;
            decimal valorTotal = 0, valorUm = 0, valorDois = 0, mediaUm = 0, mediaDois = 0;

            Console.WriteLine("Quantos produtos vão ter o aumento?");
            max = int.Parse(Console.ReadLine());

            while (cont < max)
            {
                Console.WriteLine("Qual código do produto?");
                codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor do produto?");
                valor = int.Parse(Console.ReadLine());

                aumento = valor / 100 * 20;
                valorTotal = valor + aumento;

                Console.WriteLine("O código " + codigo + " agora custa" + valorTotal);

                valorUm = valorUm + valor;
                valorDois = valorDois + valorTotal;

                cont++;
            }
            mediaUm = valorUm / cont;
            mediaDois = valorDois / cont;
            Console.WriteLine("A media dos valores antigos é: " + mediaUm);
            Console.WriteLine("A media dos valores atual é: " + mediaDois);
        }
    }
}
