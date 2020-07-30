using System;

namespace _33_F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos atletas participaram das corridas?");
            var maxAtletas = int.Parse(Console.ReadLine());

            for (var contAtleta = 0; contAtleta < maxAtletas; contAtleta++)
            {

                Console.WriteLine("Qual o nome do " + (contAtleta + 1) + "º atleta?");
                string nome = Console.ReadLine();
                Console.WriteLine("E qual a sua idade?");
                var idade = int.Parse(Console.ReadLine());


                Console.WriteLine("Quantas modalidades o atleta participou?");
                var modalidade = int.Parse(Console.ReadLine());

                for (var cont = 0; cont < modalidade; cont++)

                {
                    int tempo;
                    string nomeModalidade;

                    Console.WriteLine("Qual o nome da " + (cont + 1) + "º modalidade?");
                    nomeModalidade = Console.ReadLine();

                    Console.WriteLine("E qual foi o tempo?");
                    tempo = int.Parse(Console.ReadLine());
                    
                    Mensagem(tempo, nome, nomeModalidade);
                }
            }
        }
        static void Mensagem(int tempo, string nome, string nomeModalidade)
        {
            if (tempo < 10)
            {
                Console.WriteLine(nome + ", sua nota na " + nomeModalidade + " foi: " + 100);
            }
            else if (tempo >= 10 && tempo <= 13)
            {
                Console.WriteLine(nome + ", sua nota na " + nomeModalidade + " foi: " + 80);
            }
            else if (tempo > 13)
            {
                Console.WriteLine(nome + ", sua nota na " + nomeModalidade + " foi: " + 40);
            }
        }
    }
}
