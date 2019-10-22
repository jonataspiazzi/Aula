using System;

namespace _32
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
                            
                if ( tempo < 10 )
                {
                    pontos = 100;

                    if ( tempo > 10)
                    if  ( tempo <= 13)
                    {
                      pontos = 70;
                    }
                        if ( tempo > 13)
                        {
                        pontos = 40;
                        }
                }
                else 
                {

                }
                
                notas = notas + nomeModali + " " + pontos + " / ";

                cont = cont + 1;
            }

            Console.WriteLine( "A pontuação da atleta " + nome + " de " + idade + " anos de idade foi: "+ notas);
    }
}
}
