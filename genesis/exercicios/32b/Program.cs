using System;

namespace _32b
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cont, idade, modalidades, tempo, pontos;
            string texto, nome, nomeModali, notas;

            pontos = 0;
            cont = 0;
            notas = " ";

            Console.WriteLine("Digite o nome da atleta: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da atleta: ");
            texto = Console.ReadLine();
            idade = int.Parse(texto);

            Console.WriteLine("Em quantas modalidades a atleta participou?");
            texto = Console.ReadLine();
            modalidades = int.Parse(texto);

            while ( cont < modalidades)
            {
                Console.WriteLine("Qual o nome da Modalidade?");
                nomeModali = Console.ReadLine();

                Console.WriteLine("Qual foi o tempo?");
                texto = Console.ReadLine();
                tempo = int.Parse(texto);
                            
                if (tempo < 10)
                {
                    pontos = 100;
                }
                else 
                {
                    if (tempo <= 13)
                    {
                        pontos = 70;
                    }
                    else // (tempo > 13)
                    {
                        pontos = 40;
                    }
                }

                notas = notas + nomeModali + " " + pontos + " / ";

                cont = cont + 1;
            }

            Console.WriteLine( "A pontuação da atleta " + nome + " de " + idade + " anos de idade foi: "+ notas);
        }
    }
}
