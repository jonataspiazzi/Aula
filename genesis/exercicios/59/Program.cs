using System;

namespace _59
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cont = 0, max = 0, codigo = 0, valor = 0, porcentagem = 0, ipi = 0;

            Console.WriteLine("Qual o total de peças?");
            max = int.Parse(Console.ReadLine());

            while ( cont < max)
            {
                Console.WriteLine("Qual o código da peça?");
                codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor unitário da peça?");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual a porcentagem do IPI a ser acrescido no valor de cada peça?");
                porcentagem = int.Parse(Console.ReadLine());

                ipi = (valor * 1) * (porcentagem / 100 + 1);
                cont++;
                Console.WriteLine("O valor final da peça é: " + ipi);
            }
        }
    }
}
