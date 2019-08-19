using System;

namespace v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, soma;

            Console.Write("Digite o número 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número 3: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número 4: ");
            n4 = int.Parse(Console.ReadLine());


            // Pelo enunciado do programa, assume-se que o usuário
            // sempre irá digitar valores negativos.

            // subtrair um número negativo é o mesmo
            // de somar seu valor absoluto
            // ex: 4 - (-3)
            // é igual a: 4 + 3
            soma = - n1 - n2 - n3 - n4;

            Console.WriteLine("A soma dos valores absolutos é: " + soma);
        }
    }
}
