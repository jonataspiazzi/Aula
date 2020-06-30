using System;

namespace _13F
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;

            Console.WriteLine("Qual o max dos numeros?");
            max = int.Parse(Console.ReadLine());

            Console.WriteLine("O total dos numeros digitados é: " + Apoio.Soma(max));
        }
    }
}
