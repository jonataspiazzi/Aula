using System;

namespace _25_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes V = new Operacoes();

            Console.WriteLine("Quantos numeros seram digitados?");
            var max = int.Parse(Console.ReadLine());

            int valor = 0, requisitos = 0, negativos = 0, cont = 0;
            for (var i = 0; i < max; i++)
            {
                valor = V.GetMensagem(i);

                if(valor > -8 && valor < 10)
                {
                    requisitos = requisitos + valor;
                    cont++;
                }
                else if(valor < 0)
                {
                    negativos++;
                }
            }
            V.GetResultado(requisitos, negativos, cont);
        }
    }
    class Operacoes
    {
        public int num;
        public int GetMensagem(int i)
        {
            Console.WriteLine($"Qual o {i+1} numero? ");
            num = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"O valor absoluto de {num} é: {num}!");
            Console.ForegroundColor = ConsoleColor.Gray;
            
            return num;
        }
        public void GetResultado(int requisitos, int negativos, int cont)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("________________________________________________");
            Console.WriteLine($"A media de numeros entre -8 e 10 foi: {requisitos/cont}");
            Console.WriteLine($"E a quantidade de numeros negativos digitados foi: {negativos}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    
}
