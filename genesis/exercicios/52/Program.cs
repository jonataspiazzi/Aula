using System;

namespace _52
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numUm = 0, numDois = 0, numTres = 0, media = 0;

            Console.WriteLine("Digite o valor da primeira nota");
            numUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da segunda nota");
            numDois = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da terceira nota");
            numTres = int.Parse(Console.ReadLine());

            media = ((numUm * 2.3M) + (numDois * 2.3M) + (numTres * 5)) / (2.3M + 2.3M + 5.0M);

            Console.WriteLine("A media ponderada é: " + media);
        }
        
    }
}
