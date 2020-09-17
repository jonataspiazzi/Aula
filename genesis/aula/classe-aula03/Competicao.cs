using System;

namespace classe_aula03
{
    // Baseado no exercício 32 da lista.

    public class Competicao
    {
        public string Nome;
        public double Tempo; // Em segundos

        public Competicao(string nome, double tempo)
        {
            Nome = nome;
            Tempo = tempo;
        }

        public int GetPontuacao()
        {
            if (Tempo < 10)
            {
                return 100;
            }
            else if (Tempo < 13)
            {
                return 70;
            }
            else
            {
                return 40;
            }
        }
    }
}
