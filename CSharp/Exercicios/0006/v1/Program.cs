using System;

namespace v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            int res = num + 20;

            Console.WriteLine("O número + 20: " + res);
            Console.ReadKey();
        }
    }
}
