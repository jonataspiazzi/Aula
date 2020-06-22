using System;

namespace 9  - Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = 0, numB = 0;
            int resultado = 0;
            string funcao = "";

            Console.WriteLine("CALCULADORA GENESIS 0.1");
            Console.WriteLine(" ");
            numA = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            funcao = Console.ReadLine();

            Console.WriteLine(" ");
            numB = int.Parse(Console.ReadLine());

            if (funcao == "+")
            {
                Console.WriteLine(" = " + funcoes.soma(numA, numB, resultado));
            }
            else if (funcao == "-")
            {
                Console.WriteLine(" = " + funcoes.subitracao(numA, numB, resultado));
            }
            else if (funcao == "*")
            {
                Console.WriteLine(" = " + funcoes.multiplicacao(numA, numB, resultado));
            }
            else if (funcao == "/")
            {
                Console.WriteLine(" = " + funcoes.divisao(numA, numB, resultado));
            }
        }
    }
}