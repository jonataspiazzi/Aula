using System;

namespace _13F
{
    public class Apoio
    {
        public static int Soma(int max = 0)
        {
            int soma = 0;
            for(int cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero");
                int num = int.Parse(Console.ReadLine());

                soma = soma + num;
            }
            return soma;
        }
    }
}
