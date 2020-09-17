using System;

namespace classe_aula03
{
    // Baseado no exercício 32 da lista.

    public class Program
    {
        static void Main(string[] args)
        {
            // Entrada 

            Console.WriteLine("Digite o nome do atleta: ");
            var nomeAtetla = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de competições que ele(a) participou:");
            var qtdCompeticoes = int.Parse(Console.ReadLine());

            //var atleta = new AtletaV1(nomeAtetla, qtdCompeticoes);
            var atleta = new AtletaV2(nomeAtetla, qtdCompeticoes);

            for (var i = 0; i < qtdCompeticoes; i++)
            {
                Console.WriteLine($"Digite o nome da competição {i + 1}:");
                var nomeCompeticao = Console.ReadLine();

                Console.WriteLine($"Digite o tempo da competição {i + 1} em segundos:");
                var tempo = double.Parse(Console.ReadLine());

                atleta.AdicionarCompeticao(i, nomeCompeticao, tempo);
            }



            // Processamento

            var pontos = atleta.GetPontuacaoTotal();



            // Saida

            Console.WriteLine($"O(A) atleta {atleta.Nome} pontuou: {pontos} pontos.");
        }
    }
}
