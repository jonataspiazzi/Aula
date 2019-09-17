using System;

namespace _22_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string texto;
          
            num = 0;

            Console.WriteLine("Digite o numero: ");
            texto = Console.ReadLine();
            num = int.Parse(texto);
           
            if ( num%2==0 )
            {
           num = num * 3;
            }
            else
            {
            num = num * 2;
            }

            Console.WriteLine( num );
        }
    }
}
