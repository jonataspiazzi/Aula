using System;

namespace _61
{
    class Program
    {
        static void Main(string[] args)
        {
             int max, cont = 0;
             int total = 0;

            Console.WriteLine("Quantos numeros seram digítados?");
            max = int.Parse(Console.ReadLine());

            int[] num = new int[max];

            while (cont < max)
            {
                Console.WriteLine("Digíte o " + (cont + 1) + "º numero");
                num[cont] = int.Parse(Console.ReadLine());
                 
                total += num[cont];

                cont++;
            }
            int media;

            media = total / max;

            Console.WriteLine("A media dos números digitados é " + media);

  
        }
    }
}
