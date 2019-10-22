using System;

namespace _38
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2/50 + 22/49 + 23/48 + . . . 250/1. //
            decimal soma;

            soma = ( 2 / 50 ) + ( 22 / 49 ) + ( 23 / 48 ) + ( 250 / 1);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O resultado da soma 2/50 + 22/49 + 23/48 + 250/1 é: " + soma);
        }
    }
}
