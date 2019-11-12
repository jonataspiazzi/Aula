using System;

namespace _59_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, max = 0;
            int[] codigo = new int[10];
            int[] valor = new int[10];
            int[] porcentagem = new int[10];
            decimal ipi = 0;

            Console.WriteLine("Qual o total de peças?");
            max = int.Parse(Console.ReadLine());

            while (cont < max)
            {
                Console.WriteLine("Qual o código da peça " + (cont + 1) + "?");
                codigo[cont] = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o valor unitário da peça " + codigo[cont] + "?");
                valor[cont] = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a porcentagem do IPI a ser acrescido no valor de cada peça " + codigo[cont] + "?");
                porcentagem[cont] = int.Parse(Console.ReadLine());

                cont++;
            }

            cont = 0;

            while (cont < max)
            {
                ipi = (valor[cont] * 1) * (porcentagem[cont] / 100M + 1);
                Console.WriteLine("O valor final da peça " + codigo[cont] + " é: " + ipi);

                cont++;
            }
        }
    }
}
