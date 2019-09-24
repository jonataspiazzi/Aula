using System;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n1, n2, n3, cont, num;
           string texto, numeros;

            n1 = 1;
            n2 = 1;
            n3 = n1 + n2;
            cont = 0;
            num = 0;
            numeros = " ";

            Console.WriteLine("Digite um numero");
            texto = Console.ReadLine();
            num = int.Parse(texto);

            while ( cont < 1)
            {
                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;

                cont = cont + 1;

                numeros = numeros + n3 + " ";
            }

            if ( num = numeros)

            {
            Console.WriteLine( num + " pertence aos numeros Fibonacci");
            }
            else
            { 
            Console.WriteLine( num + " não pertence aos numeros Fibonacci");
            }

            Console.WriteLine( n3);
            
        }
    }
}
