using System;

namespace _42_B
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = 1, maior = int.MinValue;

            while(num > 0)
            while(num < 0)
            {
                if (num > maior)
                {
                    maior = num;
                }

                Console.WriteLine("Digite um número");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("O maior número é: " + maior);
        }
    }
}
