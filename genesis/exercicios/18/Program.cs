using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B ;
            string texto;
                       
            Console.WriteLine("Qual o valor de A?");
            texto = Console.ReadLine();
            A = int.Parse(texto);
            Console.WriteLine("Qual o valor de B?");
            texto = Console.ReadLine();
            B = int.Parse(texto);
            if (A >= B)
            {
                Console.WriteLine(A + "é maior ou igual a" + B);
            }
            else 
            {
                Console.WriteLine(A + "é menor do que " + B);
            }
        }
    }
}
