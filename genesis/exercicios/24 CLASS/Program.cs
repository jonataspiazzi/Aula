using System;

namespace _24_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            ValorAbsoluto V = new ValorAbsoluto();

            Console.WriteLine("Digite um numero");
            V.num = int.Parse(Console.ReadLine());

            //aqui e...
            var absoluto = V.GetDescobrirValor(V.num);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"O valor absoluto de {V.num} é: {absoluto}!!");
            Console.ForegroundColor = ConsoleColor.Gray;
            
          
        }
    }
    class  ValorAbsoluto
    {
        public int num;
        public int GetDescobrirValor(int num)
        {
            //... aqui eu usei o mesmo nome de variavel, analisando o codigo, o que eu fiz foi algo "errado" no contexto do padrão dos programadores? 
            var absoluto = num;
            return num;
        }
    }
}
