using System;

namespace _33_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Atleta A = new Atleta();

            var max = A.GetLeiaInteiro("Quantos atletas participaram?");
            var maxCom = A.GetLeiaInteiro("Quantas modalidades há na competição?");

            A.nome = new string[max]; A.idade = new int[max]; A.nota = new int[max,maxCom];
            A.NomeDaModalidade = new string[max,maxCom]; A.tempoDaModalidade = new int[max,maxCom];

            for(var i = 0; i < max; i++)
            {
                A.nome[i] = A.GetLeiaString($"Qual o nome do {i+1}º atleta?");

                for(var j = 0; j <maxCom; j++)
                {
                    A.NomeDaModalidade[i,j] = A.GetLeiaString($"Qual o nome da {j+1}º modadelidade que você participou {A.nome[i]}?");
                    A.tempoDaModalidade[i,j] = A.GetLeiaInteiro($"E qual foi o seu tempo?");

                    if(A.tempoDaModalidade[i,j] < 10)
                    {
                        A.nota[i,j] = 100;
                    }
                    else if (A.tempoDaModalidade[i,j] >= 10 && A.tempoDaModalidade[i,j] <= 13)
                    {
                        A.nota[i,j] = 70;
                    }
                    else if (A.tempoDaModalidade[i,j] > 13)
                    {
                        A.nota[i,j] = 40;
                    }
                }
            }
            for (var i = 0; i < max; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{A.nome[i]}");
                Console.ForegroundColor = ConsoleColor.Gray;

                for (var j = 0; j < maxCom; j++)
                {
                    Console.WriteLine($"{A.NomeDaModalidade[i,j]} = {A.nota[i,j]}");
                }
            }
        }
    }
    class Atleta
    { 
        public string [] nome;
        public int [] idade;
        public string [,] NomeDaModalidade;
        public int [,] tempoDaModalidade;
        public int [,] nota;

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
    }
}
