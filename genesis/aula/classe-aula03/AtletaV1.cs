using System;

namespace classe_aula03
{
    // Baseado no exercício 32 da lista.

    public class AtletaV1
    {
        public string Nome;
        public string[] NomeCompeticoes;
        public double[] TempoCompeticoes;

        public AtletaV1(string nome, int numeroDeCompeticoes)
        {
            Nome = nome;
            NomeCompeticoes = new string[numeroDeCompeticoes];
            TempoCompeticoes = new double[numeroDeCompeticoes];
        }

        public void AdicionarCompeticao(int index, string nome, double tempo)
        {
            NomeCompeticoes[index] = nome;
            TempoCompeticoes[index] = tempo;
        }

        public int GetPontuacaoTotal()
        {
            var total = 0;

            for (var i = 0; i < TempoCompeticoes.Length; i++)
            {
                var tempo = TempoCompeticoes[i];

                if (tempo < 10)
                {
                    total += 100;
                }
                else if (tempo < 13)
                {
                    total += 70;
                }
                else
                {
                    total += 40;
                }
            }

            return total;
        }
    }
}
