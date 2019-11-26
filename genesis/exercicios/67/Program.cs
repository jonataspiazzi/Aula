using System;

namespace _67
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int [] numA = new int [8];
            int [] numB = new int [8];

            

            while (cont < 8)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º numero do vetor A");
                numA[cont] = int.Parse(Console.ReadLine());

                numB[cont] = numA[cont] * 3;

                cont++;
            }
            cont = 0;
            while (cont < 8)
            {
                Console.WriteLine("O valor do " + (cont + 1) + "º numero multiplicado por 3 é: " + numB);
                cont++;
            }
        }
    }
}
