using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;

            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            soma = Program.Soma(n1, n2);

            Console.WriteLine("A soma dos dois números é: " + soma);
        }

        static int Soma(int e, int d)
        {
            int s;

            s = e + d;

            return s;
        }
    }
}
