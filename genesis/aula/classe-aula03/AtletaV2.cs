using System;

namespace classe_aula03
{
    // Baseado no exercício 32 da lista.

    public class AtletaV2
    {
        public string Nome;
        public Competicao[] Competicoes;

        public AtletaV2(string nome, int numeroDeCompeticoes)
        {
            Nome = nome;
            Competicoes = new Competicao[numeroDeCompeticoes];
        }

        public void AdicionarCompeticao(int index, string nome, double tempo)
        {
            Competicoes[index] = new Competicao(nome, tempo);
        }

        public int GetPontuacaoTotal()
        {
            var total = 0;

            for (var i = 0; i < Competicoes.Length; i++)
            {
                var competicao = Competicoes[i];

                total += competicao.GetPontuacao();
            }

            return total;
        }
    }
}
