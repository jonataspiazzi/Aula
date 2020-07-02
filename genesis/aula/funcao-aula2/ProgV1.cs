using System;

namespace funcao_aula2
{
    public class ProgV1
    {
        public static void Executar()
        {
            int max = EntradaSaida.LeiaInt("Qual o max dos numeros?", 2, 10);

            EntradaSaida.ImprimeOResultado(ProgV1.Soma(max));
        }

        public static int Soma(int max = 0)
        {
            int soma = 0;

            for (int cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero");
                int num = int.Parse(Console.ReadLine());

                soma = soma + num;
            }

            return soma;
        }
    }
}
