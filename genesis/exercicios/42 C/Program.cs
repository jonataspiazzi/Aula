using System;

namespace _42_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, maior = 0; 
            int num = 0, max = Int32.MaxValue;

            for (cont = 1; cont < max; cont++)
            {
                Console.WriteLine("Digite um numero");
                num = int.Parse(Console.ReadLine());

                if(num > maior)
                {
                   maior = num;
                }
                if (num == 0)
                {
                    max = 0;
                }
            }

            Console.WriteLine("O maior numero digitado foi: " + maior );
        }
    }
}
