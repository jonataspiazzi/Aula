using System;

namespace segAula_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Digite o valor de a: ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            var b = int.Parse(Console.ReadLine());

            var soma = Program.Soma(a, b);

            Console.WriteLine("O valor de a + b = " + soma);

            soma = Program.Soma(18, 30);

            Console.WriteLine("O valor de a + b = " + soma);
        }

        static int Soma(int a, int b)
        {
            var soma = a + b;

            return soma;
        }
    }
}
