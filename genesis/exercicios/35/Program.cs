using System;

namespace _35
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal max, cont, num;
            string texto, par, impar;

            par = "";
            impar= "";
            cont = 0;
            
            Console.WriteLine("Quantos numeros você vai digitar?");
            texto = Console.ReadLine();
            max = int.Parse(texto);

            while (cont < max)
            {
                Console.WriteLine("Digite um numero");
                texto = Console.ReadLine();
                num = int.Parse(texto);

                if ( num%2==0 )
                    { // par
                       par = par + num + " / "; 
                    }
                else
                    { // impar
                      impar = impar + num + " / ";  
                    } 
                    
                cont = cont + 1; 
           }

           Console.WriteLine("Os numeros par são: " + par);
           Console.WriteLine("OS numeros impar são: " + impar);
        }
    }
}
