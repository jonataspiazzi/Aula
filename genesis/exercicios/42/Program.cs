using System;

namespace _42
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = 0, maior = int.MinValue;

            Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());

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
