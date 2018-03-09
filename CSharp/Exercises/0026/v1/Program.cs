using System;

namespace Exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            long menor, maior, auxiliar, cont;

            menor = 1;
            maior = 1;
            cont = 0;

            Console.Write(menor + ", ");
            Console.Write(maior + ", ");

            while (cont < 50)
            {
                auxiliar = menor + maior;
                menor = maior;
                maior = auxiliar;
                Console.Write(maior + ", ");

                cont++;
            }
        }
    }
}
