using System;

namespace _23_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos habitantes fizeram parte da pesquisa?");
            var max = int.Parse(Console.ReadLine());

            Habitante H = new Habitante();
            H.nome = new string [max]; H.idade = new int[max];
            var dezH = 0;

            for(var i = 0; i < max; i++)
            {
                Console.WriteLine("Qual o nome do " + (i+1) + "º habitante?");
                H.nome[i] = Console.ReadLine();

                Console.WriteLine("E qual a sua idade?");
                H.idade[i] = int.Parse(Console.ReadLine());
                
                if (H.idade[i] > 25 && H.idade[i] < 40)
                {
                    dezH++;
                    if(dezH > 9)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("O limite de 10 habitantes foi atingido");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }
                }

            }
            for(var i = 0; i < max; i++)
            {
                H.GetControleDeIdade(i, H.idade, H.nome);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Os demais participantes não fazem parte do grupo dos 25 a 40 anos.");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
    class Habitante
    {
        public string [] nome;
        public int [] idade;

        public void GetControleDeIdade(int i, int [] idade, string [] nome)
        {
            if (idade[i] > 25 && idade[i] < 40)
            {
                Console.WriteLine(nome[i] + " tem entre 25 e 40 anos.");
            }
        }
    }
}
