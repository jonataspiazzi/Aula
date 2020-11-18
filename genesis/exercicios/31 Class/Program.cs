using System;

namespace _31_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas viagens foram feitas?");
            int max = int.Parse(Console.ReadLine());

            Formulas F = new Formulas();

            F.nome = new string[max]; F.tempo = new int [max];
            F.velocidade = new int[max]; F.gasolina = new decimal [max];

            for(var i = 0; i < max; i++)
            {
                F.nome[i]= F.GetLeiaString($"Qual o nome do motorista do {i+1}º carro?");
                F.tempo[i] = F.GetLeiaInteiro($"Quanto tempo a viagem durou?");
                F.velocidade[i] = F.GetLeiaInteiro($"Qual era a sua velocidade?");

                F.gasolina[i] = F.GetSoma(i);
            }
            Console.ForegroundColor = ConsoleColor.Red;

            for(var i = 0; i < max; i++)
            {
                Console.WriteLine($"{F.nome[i]} gastou {F.gasolina[i]} litros de gasolina em uma viagem que levou {F.tempo[i]} horas.");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Formulas
    {
        public int [] tempo;
        public int [] velocidade;
        public string [] nome;
        public decimal [] gasolina;
        public string GetLeiaString(string mensagem)
        {
            Console.WriteLine(mensagem);
            return Console.ReadLine();
        }
        public int GetLeiaInteiro(string mensagem)
        {
            Console.WriteLine(mensagem);
            return int.Parse(Console.ReadLine());
        }
        public int GetSoma(int i)
        {
            var distanc = tempo[i] * velocidade[i];
            var litros = distanc / 12;
            return litros;
        }
    }
}
