using System;

namespace v1
{
    partial class Program
    {
        static void ReadVar(out int v)
        {
            v = int.Parse(Console.ReadLine());
        }

        static void ReadVar(out decimal v)
        {
            v = decimal.Parse(Console.ReadLine());
        }

        static void ReadVar(out bool v)
        {
            v = bool.Parse(Console.ReadLine());
        }

        static void ReadVar(out string v)
        {
            v = Console.ReadLine();
        }

        static void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Program
    {
        static void Main()
        {
            // variaveis
            int n1, n2, n3, soma;
            
            // programa
            n1 = 0;
            n2 = 0;
            n3 = 0;
            soma = 0;

            WriteLine("Digite o primeiro valor: ");
            ReadVar(out n1);
            WriteLine("Digite o segundo valor: ");
            ReadVar(out n2);
            WriteLine("Digite o terceiro valor: ");
            ReadVar(out n3);

            soma = n1 + n2 + n3;

            WriteLine("A soma dos três valores é: " + soma);
        }
    }
}
