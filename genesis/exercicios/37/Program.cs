using System;

namespace _37
{
    class Program
    {
        static void Main(string[] args)
        { 
            int num;
            string texto;
            
            Console.WriteLine("Digite um número");
            texto = Console.ReadLine();
            num = int.Parse(texto);

            if ( num < 1)
            {
              return 1;
            }
            else 
            {
                return num * Fatorial(num - 1);
            }

            for (int n = 1; n <= num; n++)

            Console.WriteLine("{0} ! = {1}", i, Fatorial(i));

        }
    }
}
