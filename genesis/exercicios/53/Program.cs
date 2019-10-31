using System;

namespace _53
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cont = 0, max = 0, valor = 0, distribuidor = 0, imposto = 0, fabrica = 0;
            string carro = "";

            Console.WriteLine("Quantos carros vão ser analisádos?");
            max = int.Parse(Console.ReadLine());

            while (cont < max)
            {
                Console.WriteLine("Qual o modelo do carro?");
                carro = Console.ReadLine();
                Console.WriteLine("Qual o valor do carro?");
                valor = int.Parse(Console.ReadLine());

                distribuidor = valor / 100 * 28;
                imposto = valor / 100 * 45;
                fabrica = valor - distribuidor - imposto;

                cont++;
                Console.WriteLine(carro);
                Console.WriteLine("O custo de fabrica é: " + fabrica);
                Console.WriteLine("O custo em imposto é: " + imposto);
                Console.WriteLine("O Custo do distribuidor é: " + distribuidor);
            }
        }
    }
}
