using System;

namespace exemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var athlete = new Athlete();

            Console.Write("Digite o nome: ");
            athlete.Name = Console.ReadLine();

            Console.Write("Digite a idade: ");
            athlete.Age = int.Parse(Console.ReadLine());

            Console.Write("Digite quantas provas serão lidas: ");
            int qtd = int.Parse(Console.ReadLine());

            athlete.Competitions = new Competition[qtd];

            for (int i = 0; i < qtd; i++) {
                athlete.Competitions[i] = new Competition();

                Console.Write("Digite o nome da prova: ");
                athlete.Competitions[i].Name = Console.ReadLine();

                Console.Write("Digite o tempo da prova: ");
                athlete.Competitions[i].Time = int.Parse(Console.ReadLine());
            }

            int totalPoints = athlete.CalcTotalPoints();

            Console.WriteLine($"O total de pontos é {totalPoints}.");
        }
    }
}
