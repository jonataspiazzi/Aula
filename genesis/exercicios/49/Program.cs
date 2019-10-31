using System;

namespace _49
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal codigo = 2, quantidade = 0, valor = 0, cont = 0, valorTotal = 0, imposto = 0;
            string descrição = "";

            while (codigo > 0)
            {
            Console.WriteLine("Qual o codigo do produto?");
            codigo = int.Parse(Console.ReadLine());

            if (codigo > 0)
            {
                Console.WriteLine("Qual a quantidade do produto?");
                quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o valor unitario?");
                valor = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a descrição do produto?");
                descrição = Console.ReadLine();

                valorTotal += valor; 
                cont++; 
            }
            }
            imposto = valorTotal / 100 * 5;
            Console.WriteLine("O total de itens da nota fiscal é: " + cont);
            Console.WriteLine("O valor total da nota é: " + valorTotal);
            Console.WriteLine("O valor total dos impostos é: " + imposto);
        }
    }
}
