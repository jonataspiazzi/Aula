using System;

namespace _52_B
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numUm = 0, numDois = 0, numTres = 0;
            decimal mediaUm = 0, mediaDois = 0, mediaTres = 0, mediaTotal = 0, resultado = 0;

            Console.WriteLine("Digite o valor da primeira nota");
            numUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da segunda nota");
            numDois = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da terceira nota");
            numTres = int.Parse(Console.ReadLine());

            mediaUm = numUm * 2.3M;
            mediaDois = numDois * 2.3M;
            mediaTres = numTres * 5;
            mediaTotal = mediaUm + mediaDois + mediaTres;
            resultado = mediaTotal / 9.6M;

            Console.WriteLine("A media ponderada é: " + resultado);
        }
    }
}
