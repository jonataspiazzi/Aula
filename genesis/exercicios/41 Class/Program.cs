using System;

namespace _41_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // infantil A     infantil  B   juvenil  A      juvenil    B      adulto
            int grupoUm = 0, grupoDois = 0, grupoTres = 0, grupoQuatro = 0, grupoCinco = 0;

            Console.WriteLine("Quantos nadadores há?");
            var max = int.Parse(Console.ReadLine());

            CategoriaDoNadador C = new CategoriaDoNadador();

            C.idade = new int [max];  C.nome = new string [max];

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Qual o nome do {i+1}º nadador?");
                C.nome[i] = Console.ReadLine();
                
                Console.WriteLine($"Qual a idade do {i+1}º nadador?");
                C.idade[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < max; i++)
            {

                if (C.idade[i] >= 5 && C.idade[i] <= 7)
                {
                    Console.WriteLine($"{C.nome[i]} pertence ao categoria infantil A");
                    grupoUm++;
                }
                else if (C.idade[i] >= 8 && C.idade[i] <= 11)
                {
                    Console.WriteLine($"{C.nome[i]} pertence ao categoria infantil B");
                    grupoDois++;
                }
                else if (C.idade[i] >= 12 && C.idade[i] <= 13)
                {
                    Console.WriteLine($"{C.nome[i]} pertence ao categoria juvenil A");
                    grupoTres++;
                }
                else if (C.idade[i] >= 14 && C.idade[i] <= 17)
                {
                    Console.WriteLine($"{C.nome[i]} pertence ao categoria juvenil B");
                    grupoQuatro++;
                }
                else if (C.idade[i] >= 18)
                {
                    Console.WriteLine($"{C.nome[i]} pertence ao categoria adulto");
                    grupoCinco++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A categoria infantil A tem {grupoUm} alunos.");
            Console.WriteLine($"A categoria infantil B tem {grupoDois} alunos.");
            Console.WriteLine($"A categoria juvenil A tem {grupoTres} alunos.");
            Console.WriteLine($"A categoria juvenil A tem {grupoQuatro} alunos.");
            Console.WriteLine($"A categoria adulto A tem {grupoCinco} alunos.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class CategoriaDoNadador
    {
        public int [] idade;
        public string [] nome;
    }
}
