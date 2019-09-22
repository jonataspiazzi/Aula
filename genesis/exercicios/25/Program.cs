using System;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
           int num, absoluto, max,soma, contmedia, media, negativos, cont;
            string texto;

            num = 0;
            cont = 0;
            max = 0;
            contmedia = 0;
            soma = 0;
            media = 0;
            absoluto = 0;
            negativos = 0;

            Console.WriteLine( "Quantos numeros seram digitados?");
            texto = Console.ReadLine();
            max = int.Parse(texto);

            while ( cont < max)
            {
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

            Console.WriteLine( "O valor absoluto de" + " " + num + " " +  "é" + " " + absoluto);

            if (num < 0)
            {
                negativos = negativos + 1;
            }
            else
            {

            }

            if ( num > -8)
            if ( num < 10)

            {
                soma = soma + 1;
                contmedia = contmedia + num;
            }
            else
            {

            }
            cont = cont + 1;

            }
            media = contmedia / soma;

            Console.WriteLine("A media dos numeros é "+ media);
            Console.WriteLine( negativos + " numeros são negativos");
        }
    }
}
