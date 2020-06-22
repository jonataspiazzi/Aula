using System;

namespace _46_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, num = 0, max = 1;
            int somaNegativo = 0;

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite um numero!");
                num = int.Parse(Console.ReadLine());

                if(num == 0)
                {
                    max = -1;
                }
                if (num < 0)
                {
                    somaNegativo = somaNegativo + num;
                }
                cont--;
            }

            Console.WriteLine("A soma dos valores digitados é: " + somaNegativo);
        }
    }
}
