using System;

namespace _82
{
    class Program
    {
        static void Main(string[] args)
        {
                        int cont = 0, max = 5;
            int [] num = new int [max];
            
            Console.WriteLine("Digite 5 valores para formar um numero binario");
            Console.WriteLine("Digite apenas 0 ou 1");

            for (cont = 0; cont < max; cont++)
            
            {
                Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero");
                num[cont] = int.Parse(Console.ReadLine());
            }

            int elevado = 5, total = 0;
            int A = 0;
            int expoente = 0, contExpoente = 0;

            for(cont = 0; cont < max; cont++)
            {
                A = num[cont];

                while (contExpoente < elevado)
                {
                    A *= expoente;
                    contExpoente++;
                }

                elevado--;

                total = total + A;
            }

            Console.WriteLine("O valor do numero " + num[0] + num[1] + num[2] + num[3] + num[4] + " é: " + total);

        }
    }
}
