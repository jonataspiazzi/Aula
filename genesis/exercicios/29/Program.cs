using System;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, cont;
            string termo, termos;

            Console.WriteLine(" 20 primeiros termos da seqüência: 4/1 são:");

            a = 4;
            b = 1;
            termo = "";
            termos = "";
            cont = 0;

            while (cont<20)

            {

            termo = a + "/" + b;

            termos = termos + " " + termo;

            a = a * 3;
            b = b + 3;

            cont = cont + 1;

            }

            Console.WriteLine( termos);






        }
    }
}
