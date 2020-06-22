using System;

namespace _9C
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
                Console.WriteLine(" = " + funcao.soma(resultado));
            }
            else if (funcao == "-")
            {
                Console.WriteLine(" = " + funcao.subitracao(resultado));
            }
            else if (funcao == "*")
            {
                Console.WriteLine(" = " + funcao.multiplicacao(resultado));
            }
            else if (funcao == "/")
            {
                Console.WriteLine(" = " + funcao.divisao(resultado));
            }
        }
    }
}
