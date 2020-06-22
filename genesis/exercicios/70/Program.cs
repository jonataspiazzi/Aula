using System;

namespace _70
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, cont = 0;

            Console.WriteLine("Quantos elementos os vetores tem?");
            max = int.Parse(Console.ReadLine());

            int [] numA = new int [max];
            int [] numB = new int [max];

            while (cont < max)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero do vetor A");
                numA[cont] = int.Parse(Console.ReadLine());

                cont++;
            }

            cont = 0;

            while (cont < max)
            {
                numB[cont] = numA[cont] * numA[cont];

                Console.WriteLine("O valor do " + (cont + 1) + "º numero do vetor B é: " + numB[cont]);

                cont++;
            }
            
        }
    }
}
