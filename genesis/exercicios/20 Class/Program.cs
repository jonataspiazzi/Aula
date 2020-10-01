using System;

namespace _20_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos habitantes há na cidade?");
            var max = int.Parse(Console.ReadLine());

            Habitante H = new Habitante();

            H.idade = new int [max];   H.nome = new string[max];

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine("Qual o nome do " + (i+1) + "º habitante?");
                H.nome[i] = Console.ReadLine();

                Console.WriteLine("E qual a sua idade?");
                H.idade[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < max; i++)
            {
                if(H.idade[i] > 20)
                {
                    Console.WriteLine(H.nome[i] + " tem mais de 20 anos e pertence ao grupo A");
                }
                else if(H.idade[i] < 15)
                {
                    Console.WriteLine(H.nome[i] + " tem menos de 15 anos e pertence ao grupo B");
                }
            }
            Console.WriteLine("O restante não faz parte de nenhum grupo.");
        }

        public class Habitante
        {
            public string [] nome;
            public int [] idade;
        }
        
    }
}
