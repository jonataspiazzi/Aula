using System;

namespace v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            int num = int.Parse(Console.ReadLine());

            int res = Soma20(num);

            Console.WriteLine("O número + 20: " + res);
        }

        static int Soma20(int n)
        {
            return n + 20;
        }
    }
}
