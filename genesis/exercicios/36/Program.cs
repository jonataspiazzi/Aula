using System;

namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numUm, numDois, nImpar, mImpar, soma;
            string texto;

            soma = 0;
            numUm = 0;
            numDois = 0;
            nImpar = 0;
            mImpar = 0;

            Console.WriteLine("Digite o valor de M");
            texto = Console.ReadLine();
            numUm = int.Parse(texto);

            if ( numUm%2==0 )
            {
              numUm = numUm;  
            }
            else
            {
                mImpar = mImpar + numUm;
            }

            Console.WriteLine("Digite um valor maior que M");
            Console.WriteLine("Digite o valor N");
            texto = Console.ReadLine();
            numDois = int.Parse(texto);

            if ( numUm%2==0 )
            {
              numDois = numDois;  
            }
            else
            {
                nImpar = nImpar + numDois;
            }

            soma = soma + mImpar + nImpar;

            Console.WriteLine("A soma dos valores impares é " + soma);
        }
    }
}
