using System;

namespace _72
{
    class Program
    {
        static void Main(string[] args)
        {
            // Armazenando o Vetor A

            int max = 0, cont = 0;

            Console.WriteLine("Quantos elementos os vetores tem?");
            max = int.Parse(Console.ReadLine());

            int [] numA = new int [max];
            int [] numB = new int [max];

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero do vetor A");
                numA[cont] = int.Parse(Console.ReadLine());
            }

            // Transformando Vetor A em Vetor B

            int fatorial = 1;
            int contF = 1;

            for (cont = 0; cont < max; cont++)
            {

                for (contF = 1; contF <= numA[cont]; contF++)
                {
                    fatorial *= contF;
                    numB[cont] = fatorial;
                }
                fatorial = 1;
                contF = 1;

                Console.WriteLine("O valor do " + (cont + 1) + "º numero do vetor B é: " + numB[cont]);
            }
        }
    }  
}
