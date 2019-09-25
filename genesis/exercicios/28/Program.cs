using System;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num, a, b, c;
            string texto;

            Console.WriteLine("Operações que iremos fazer");
            Console.WriteLine("A - O resto da divisão de X / 5");
            Console.WriteLine("B - X² + 20");
            Console.WriteLine("C - X² - X + 2");

            Console.WriteLine("Digite o valor de X");
            texto = Console.ReadLine();
            num = int.Parse(texto);

            a = num % 5;

            b = num * num + 20;

            c = num * num - num + 2;

            Console.WriteLine("O valor de A é: " + a);
            Console.WriteLine("O valor de B é: " + b);
            Console.WriteLine("O valor de C é: " + c);
            

        }
    }
}
