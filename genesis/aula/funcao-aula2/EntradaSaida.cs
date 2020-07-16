using System;

namespace funcao_aula2
{
    public class EntradaSaida
    {
        public static int LeiaInt(string mensagem, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(mensagem);

                var a = int.Parse(Console.ReadLine());

                if (a < min)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor precisa ser maior ou igual a " + min);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (a > max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor precisa ser menor ou igual a " + max);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    return a;
                }
            }
        }

        public static int[] LeiaVetorInt(int max, string mensagem)
        {
            var nuns = new int[max];

            for (int cont = 0; cont < max; cont++)
            {
                Console.WriteLine(mensagem, cont + 1);
                nuns[cont] = int.Parse(Console.ReadLine());
            }

            return nuns;
        }

        public static int[] LeiaVetorIntComValidacao(int max, string mensagem, int minimo, int maximo)
        {
            var nuns = new int[max];

            for (int cont = 0; cont < max; cont++)
            {
                var msg = string.Format(mensagem, cont + 1);
                nuns[cont] = LeiaInt(msg, minimo, maximo);
            }

            return nuns;
        }

        //Duv aqui

        public static void ImprimeOResultado(int soma)
        {
            Console.WriteLine("O total dos numeros digitados é: " + soma);
        }
    }
}
