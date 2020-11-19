using System;

namespace _32_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Atleta A = new Atleta();

            A.nome = A.GetLeiaString("Qual o seu nome?");
            A.idade = A.GetLeiaInteiro($"E qual a sua idade {A.nome}?");
            var max = A.GetLeiaInteiro($"E em quantas modalidades você participou {A.nome}?");

            A.NomeDaModalidade = new string [max];
            A.tempoDaModalidade = new int [max];

            for (var i = 0; i < max; i++)
            {
                A.NomeDaModalidade[i] = A.GetLeiaString($"Qual o nome da {i+1}º modalidade que você participou?");
                A.tempoDaModalidade[i] = A.GetLeiaInteiro($"E qual foi seu tempo nessa modadelidade?");
            }
            for(var i = 0; i < max; i++)
            {
                Console.WriteLine($"A pontuação feita na modalidade {A.NomeDaModalidade[i]} foi {A.GetTabelaDePontuacao(i)}");
            }
        }
    }
    class Atleta
    {
        public string nome;
        public int idade;
        public string [] NomeDaModalidade;
        public int [] tempoDaModalidade;

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
        public int GetTabelaDePontuacao(int i)
        {
            int a = 0;
            if(tempoDaModalidade[i] < 10)
            {
              a = 100;  
            }
            else if (tempoDaModalidade[i] >= 10 && tempoDaModalidade[i] <= 13)
            {
                a = 70;
            }
            else if (tempoDaModalidade[i] > 13)
            {
                a = 40;
            }
            return a;
        }
    }
}
