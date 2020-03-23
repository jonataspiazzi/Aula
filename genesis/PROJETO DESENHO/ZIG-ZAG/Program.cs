using System;

namespace ZIG_ZAG
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, lado = 1, caracter = 0;
            int cont = 0, cont2 = 0, maxzig = 0; 
            int contzig = 0;

           Console.WriteLine("Quantos zigs e zags devem ser feitos?");
           maxzig = int.Parse(Console.ReadLine());

           Console.WriteLine("Quantas casas o" + " * " + "deve andar para cada lada?");
           max = int.Parse(Console.ReadLine());

           for (contzig = 0; contzig < max; contzig++)
           {
                lado = 1; caracter = 0;
                cont = 0; cont2 = 0;
                contzig = 0;

             
                for (cont = 0; cont < max; cont++)
           {
               for (caracter = 0; caracter < lado; caracter++)
               {
                   if (caracter == cont2)
                   {
                       Console.Write("*");
                   }
                   Console.Write(" ");
               }
              lado++;
              cont2++;
              Console.WriteLine("");
           }
           Console.Write("");
           int oposto = 0, menos = 0;

           oposto = max;
           menos = oposto;
           menos--;
           oposto = menos;

           for ( cont = 0; cont < max; cont++)
           {
             for (caracter = 0; caracter < max; caracter++)
             {
                 if (caracter == oposto)
                 {
                   Console.Write("*");
                 }
                 Console.Write(" ");
             }
             oposto--;
             Console.WriteLine("");
           }
           }

           
        }
    }
}
