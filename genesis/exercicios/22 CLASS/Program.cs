using System;

namespace _22_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero N = new Numero();
            
            for(var i = 1; i > 0; i++)
            {
                Console.WriteLine("Digite um numero ou digite 0 para terminar");
                N.num = int.Parse(Console.ReadLine());

                if(N.num == 0)
                {
                    break;
                }
                else if (N.num % 2 == 0) // par
                {
                    N.GetPar(N.num);
                }
                else if (N.num % 2 == 1)
                {
                    N.GetImpar(N.num);
                }
                
            }
        }
    }
    class Numero
    {
        public int num;
        public void GetImpar(int num)
        {
            var vezesTres = num * 3;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Um numero IMPAR!!");
            Console.WriteLine($"Um numero IMPAR!! O valor de {num} multiplicado por 3 é: {vezesTres}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void GetPar(int num)
        {
            var vezesDois = num * 2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Um numero PAR!!");
            Console.WriteLine($"O valor de {num} multiplicado por 2 é: {vezesDois}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
