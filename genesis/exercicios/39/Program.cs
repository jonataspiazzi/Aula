using System;

namespace _39
{
    class Program
    {
        static void Main(string[] args)
        {
            int quilos, cont, extra, contMulta, max, totalQl, multa;
            string texto;

            cont = 0;
            contMulta = 0;
            totalQl = 0;
            multa = 0;

            Console.WriteLine("Qual o total de pescadores?");
            texto = Console.ReadLine();
            max = int.Parse(texto);

            while ( cont < max)

            {
                Console.WriteLine("Quantos quilos foram pescados?");
                texto = Console.ReadLine();
                quilos = int.Parse(texto);

                if (quilos > 50)
                {
                    extra = quilos - 50;
                    contMulta = contMulta + 1;
                    totalQl = totalQl + extra;
                    multa = extra * 4;

                    Console.WriteLine(" Siga o regulamento de pesca! ");
                    Console.WriteLine("Valor da multa: " + multa);
                }
                else
                {

                }
               
                cont = cont + 1;
            }

            Console.WriteLine("Total de multas aplicadas: " + contMulta);
            Console.WriteLine("Total de quilos excedente: " + totalQl);
            Console.WriteLine("Valor total em multas: " + totalQl * 4);
        }
    }
}
