using System;

namespace _19_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos habitantes há?");
            var max = int.Parse(Console.ReadLine());

            Habitantes H = new Habitantes();
            H.nome = new string[max];  H.idade = new int[max];

            H.Entrada(max);

            Console.WriteLine("Os habitantes com mais de 20 anos são.");

            H.Saida(max);
        }
    }
    
    class Habitantes
    {
        public string [] nome;

        public int [] idade;
        
        public void Entrada(int max)
        
        {
            for (var i = 0; i < max; i++)
            {
                Console.WriteLine("Qual o nome do" + (i+1) +"º habitante?");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Qual a idade do" + (i+1) + "º habitante?");
                idade[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Saida(int max)
        {
            for (var i = 0; i < max; i++)
            {
                if (idade[i] > 20)
                {
                    Console.WriteLine(nome[i] + " " + idade[i] + " anos.");
                }
            }
        }

        
    }
}
