using System;

namespace v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int i, qtd, num;
            int[] v;

            qtd = 5;
            v = new int[qtd];

            for (i = qtd - 1; i >= 0; i--) // for invertido passa do ultimo ao primeiro.
            {
                Console.Write("Digite o " + (i + 1) + "º dígito da esquerda para direita é: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            num = 0;

            for (i = 0; i < qtd; i++)
            {
                // v[0]*2**4 + v[1]*2**3 + v[2]*2**2
                num = num + v[i] * (int)Math.Pow(2, i);
            }

            Console.WriteLine("O valor em decimal é: " + num);
        }
    }
}
