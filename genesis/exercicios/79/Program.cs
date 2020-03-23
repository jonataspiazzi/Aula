using System;

namespace _79
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, cont = 0;
            int contA = 0, contB = 0;

            Console.WriteLine("Quantos elementos os vetores A e B tem?");
            max = int.Parse(Console.ReadLine());

            int [] numA = new int [max];
            int [] numB = new int [max];

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º elemento do vetor A");
                numA[contA] = int.Parse(Console.ReadLine());
            }

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º elemento do vetor B");
                numB[contB] = int.Parse(Console.ReadLine());
            }

            int soma = 0;
            
            for (cont = 0; cont < max; cont++)
            {
                soma = 0;
                for (contA = 0; contA < max; contA++)
                {
                   if (numA[contA] == numB[contB])
                    {
                      soma++;
                    } 
                    contA++; 
                }
                Console.WriteLine("O " + numA[contA] + " aparece " + soma + " vezes no " + numB[contB]);  
                contB++;
            }
        }
    }
}
