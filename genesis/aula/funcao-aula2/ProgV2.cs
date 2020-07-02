using System;

namespace funcao_aula2
{
    public class ProgV2
    {
        public static void Executar()
        {
            int max = 0;

            Console.WriteLine("Qual o max dos numeros?");
            max = int.Parse(Console.ReadLine());

            var nuns = new int[max];

            for (int cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero");
                nuns[cont] = int.Parse(Console.ReadLine());
            }

            EntradaSaida.ImprimeOResultado(ProgV2.Soma(max, nuns));
        }

        public static int Soma(int max, int[] numeros)
        {
            int soma = 0;

            for (int cont = 0; cont < max; cont++)
            {
                soma = soma + numeros[cont];
            }

            return soma;
        }
    }
}
