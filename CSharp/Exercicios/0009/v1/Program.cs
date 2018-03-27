using System;

namespace v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, multiplo;

            cont = 0;
            while (cont <= 10)
            {
                multiplo = 7 * cont;
                
                Console.WriteLine("7 x " + cont + " = " + multiplo);

                cont++;
            }
        }
    }
}
