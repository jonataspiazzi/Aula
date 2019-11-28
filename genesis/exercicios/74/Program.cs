using System;

namespace _74
{
    class Program
    {
        static void Main(string[] args)
        {
            // Armazenando os elementos do vetor A e B.

            int max = 0, cont = 0;

            Console.WriteLine("Quantos elementos o vetor A ira ter?");
            max = int.Parse(Console.ReadLine());

            int [] numA = new int [max];

            for (cont = 0; cont < max; cont++)
            {
               Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero do elemento A");
               numA[cont] = int.Parse(Console.ReadLine());

            }
            //...

            int [] numB = new int [max];

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero do elemento B");
                numB[cont] = int.Parse(Console.ReadLine());
            }

            //Trocando os elementos dos vetores.

            int troca = 0;

            for (cont = 0; cont < max; cont++)
            {
                troca = numB[cont];
                numB[cont] = numA[cont];
                numA[cont] = troca;
            }

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("O novo valor do " + (cont + 1) + "º elemento do vetor A é:" + numA[cont]);
                Console.WriteLine("O novo valor do " + (cont + 1) + "º elemento do vetor B é:" + numB[cont]);
            }


        }
    }
}
