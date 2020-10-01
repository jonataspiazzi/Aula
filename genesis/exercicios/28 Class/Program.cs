using System;

namespace _28_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A formula deve ser aplicada em quantos numeros?");
            var max = int.Parse(Console.ReadLine());

            Formula F = new Formula();

            F.num = new int [max];
            
            for (var i = 0; i < max; i++)
            {
                Console.WriteLine("Digite o valor do " + (i+1) + "º numero");
                F.num[i] = int.Parse(Console.ReadLine());
            }
            int a = 0, b = 0, c = 0;

            for (var i = 0; i < max; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine((i+1) + "º numero.");
                Console.ForegroundColor = ConsoleColor.Gray;

                a = F.GetFormulaA(F.num[i]);
                Console.WriteLine("O resultado da formula A é: " + a);

                b = F.GetFormulaB(F.num[i]);
                Console.WriteLine("O resultado da formula B é: " + b);

                c = F.GetFormulaC(F.num[i]);
                Console.WriteLine("O resultado da formula C é: " + c);
            }

        }
        class Formula
        {
            public int [] num;
            public int GetFormulaA(int a)
            {
                int resultado = a % 5;
                return resultado;
            }
            public int GetFormulaB(int a)
            {
                int resultado = a * a + 20;
                return resultado;
            }
            public int GetFormulaC(int a)
            {
                int resultado = a * a - a + 2;
                return resultado;
            }
        }
        
    }
}
