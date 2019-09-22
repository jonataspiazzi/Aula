using System;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, absoluto;
            string texto;

            num = 0;

            Console.WriteLine(" Digite um numero");
            texto = Console.ReadLine();
            num = int.Parse(texto);

            if ( num < 0)
            {
                absoluto = 0 - num;
            }
            else 
            {
                absoluto = num;
            }

            Console.WriteLine( "O valor absoluto de" + " " + num + " " +  "é" + " " + absoluto );

        }
    }
}
