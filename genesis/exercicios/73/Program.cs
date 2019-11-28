using System;

namespace _73
{
    class Program
    {
        static void Main(string[] args)
        {
            // Armazenando os elementos do vetor A e B.

            int max = 0;

            Console.WriteLine("Quantos elementos o vetor A ira ter?");
            max = int.Parse(Console.ReadLine());

            int [] numA = new int [max];

            for (cont = 0; cont < max; cont++)
            {
               Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero do elemento A");
               numA[cont] = int.Parse(Console.ReadLine());

            }
            //...
            max = 0;

            Console.WriteLine("Quantos elementos o vetor B ira ter?");
            max = int.Parse(Console.ReadLine());

            int [] numB = new int [max];

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero do elemento B");
                numB[cont] = int.Parse(Console.ReadLine());
            }

            //Comparando os elementos

            



        }
    }
}
