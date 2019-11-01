using System;

namespace aula_vetor
{
    class Program
    {
        // Faça um programa que leia dez (10) números e no final mostre o maior deles

        static void Main(string[] args)
        {
            int maior = int.MinValue;
            int[] num = new int[10]; // tipo[] = palavra_new tipo[quantidade_espaços];
            //string[] nomes = new string[8];
            int cont = 0;
            
            while (cont < 10)
            {
                Console.Write("Digite o " + (cont + 1) + " numero: ");
                
                num[cont] = int.Parse(Console.ReadLine());
                
                cont++;
            }

            cont = 0;

            while (cont < 10)
            {
                if (num[cont] > maior)
                {
                    maior = num[cont];
                }

                cont++;
            }

            Console.WriteLine("O maior número digitado é " + maior);
        }
    }
}
