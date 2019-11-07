using System;

namespace _59_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, max = 0, ipi = 0;
            int[] codigo = new int[10];
            int[] valor = new int[10];
            int[] porcentagem = new int[10];

            Console.WriteLine("Qual o total de peças?");
            max = int.Parse(Console.ReadLine());

            while ( cont < max)
            {
                Console.WriteLine("Qual o código da peça?");
                codigo[cont] = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o valor unitário da peça?");
                valor[cont] = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a porcentagem do IPI a ser acrescido no valor de cada peça?");
                porcentagem[cont] = int.Parse(Console.ReadLine());

                ipi = (valor * 1) * (porcentagem / 100 + 1);
                cont++;
                Console.WriteLine("O valor final da peça é: " + ipi);
            }
        }
    }
}
