using System;

namespace _22_F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor de num");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O dobro de " + num + " é " + Par(num));
            }
            else
            {
                Console.WriteLine("O triplo de " + num + " é " + Impar(num));
            }
        }

        static int Impar(int num)
        {
            int A = num * 3;
            return A;
        }
        static int Par(int num)
        {
            int A = num * 2;
            return A;
        }
    }
}
