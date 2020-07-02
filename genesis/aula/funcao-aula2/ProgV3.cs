using System;

namespace funcao_aula2
{
    public class ProgV3
    {
        public static void Executar()
        {
            var max = EntradaSaida.LeiaInt("Qual o max dos numeros?", 2, 10);

            var numeros = EntradaSaida.LeiaVetorInt(max, "Digite o valor do {0}º numero");

            int soma = 0;

            for (int cont = 0; cont < max; cont++)
            {
                soma = soma + numeros[cont];
            }

            EntradaSaida.ImprimeOResultado(soma);
        }
    }
}
