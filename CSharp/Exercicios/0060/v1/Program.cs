using System;

namespace Exercise60
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elementos = new int[10];
            int i;

            //for (i = 0; i < 10; i++)
            //{
            //    elementos[i] = int.Parse(Console.ReadLine());
            //}

            i = 0;
            while (i < 10)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + ": ");
                elementos[i] = int.Parse(Console.ReadLine());

                i++;
            }

            i = 0;
            while (i < 10)
            {
                Console.WriteLine("Elemento " + (i + 1) + ": " + elementos[i]);
                i++;
            }
        }
    }
}
