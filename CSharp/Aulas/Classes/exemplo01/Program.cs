using System;

namespace exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string name = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Digite quantas provas serão lidas: ");
            int qtd = int.Parse(Console.ReadLine());

            string[] runNames = new string[qtd];
            int[] runTimes = new int[qtd];

            for (int i = 0; i < qtd; i++) {
                Console.Write("Digite o nome da prova: ");
                runNames[i] = Console.ReadLine();

                Console.Write("Digite o tempo da prova: ");
                runTimes[i] = int.Parse(Console.ReadLine());
            }

            int totalPoints = 0;

            for (int i = 0; i < qtd; i++) {
                if (runTimes[i] < 10) {
                    totalPoints += 100;
                }
                else if (runTimes[i] < 13) {
                    totalPoints += 70;
                }
                else {
                    totalPoints += 40;
                }
            }

            Console.WriteLine($"O total de pontos é {totalPoints}.");
        }
    }
}
