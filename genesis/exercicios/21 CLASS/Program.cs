using System;

namespace _21_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas pessoas participaram da pesquisa?");
            var max = int.Parse(Console.ReadLine());

            Pesquisa P = new Pesquisa();

            P.idade = new int[max];  P.nome = new string[max];

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Qual o nome da {1+i}º pessoa?");
                P.nome[i] = Console.ReadLine();

                Console.WriteLine("E qual a sua idade?");
                P.idade[i] = int.Parse(Console.ReadLine());

                if (P.idade[i] > 20)
                {
                    P.maiorQueVinte = P.maiorQueVinte + P.nome[i] + "-";

                    if (P.idade[i] > 40)
                    {
                        P.maiorQueQuarenta++;
                    }
                }
                
            }

            Console.WriteLine($"{P.maiorQueVinte} tem mais de vinte anos.");
            Console.WriteLine($"E {P.maiorQueQuarenta} pessoas tem mais de quarenta anos.");

        }
    }
    class Pesquisa
    {
        public string maiorQueVinte;
        public int maiorQueQuarenta;
        public string [] nome;
        public int [] idade;
    }
}
