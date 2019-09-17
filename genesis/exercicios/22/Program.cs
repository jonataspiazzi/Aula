using System;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, impar, par;
            string texto;
          
            num = 0;
            impar = 0;
            par = 0;

            Console.WriteLine("Digite o numero: ");
            texto = Console.ReadLine();
            num = int.Parse(texto);
           
            if ( num%2==0 )
            {
            impar = num * 3;
            Console.WriteLine( impar );
            }
            else
            {
            par = num * 2;
            Console.WriteLine( par );
            }
        }
    }
}
