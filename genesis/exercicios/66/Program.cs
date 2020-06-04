using System;

namespace _66
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos numeros os vetores iram ter?");
            int max = int.Parse(Console.ReadLine());

            int contA = 0, contB = 0, cont = 0, num = 0;
            int [] numA = new int [max];
            int [] numB = new int [max];

            while (contA < max)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero do grupo A");
                numA[contA] = int.Parse(Console.ReadLine());

                contA++;
                cont++;
            }
            cont = 0;
            while (contB < max)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero do grupo B");
                numB[contB] = int.Parse(Console.ReadLine());

                contB++;
                cont++;
            }

            cont = 0;
            contA = 0;
            contB = 0;

            Console.WriteLine("Digite um numero");
            num = int.Parse(Console.ReadLine());

            if (num == numA[contA])
            {
                if (num == numB[contB])
                {
                    Console.WriteLine("O numero " + num + " pertece ao grupo A e B");
                }
                Console.WriteLine("O numero " + num + " pertece ao grupo A"); 
            }
            else if (num == numB[contB])
            {
                Console.WriteLine("O numero " + num + " pertence ao grupo B");
            }
            else
            {
                Console.WriteLine("O numero não pertece a nenhum grupo");
            }
           

        }
    }
}
