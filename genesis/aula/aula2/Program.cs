using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, absoluto;
            string texto;

            Console.WriteLine("Digite um número: ");
            texto = Console.ReadLine();
            valor = int.Parse(texto);

            if (valor < 0)
            {
                absoluto = 0 - valor;
            }
            else
            {
                absoluto = valor;
            }

            Console.WriteLine("O absoluto do valor é: " + absoluto);
        }
    }
}
