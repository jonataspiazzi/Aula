using System;

namespace _48
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            decimal seleção = 0, porcentagem = 0, cont = 0, brasil = 0, argentina = 0, alemanha = 0, portugal = 0;
            decimal pBrasil = 0, pArgentina = 0, pAlemanha = 0, pPortugal = 0;

            while (cont < 50)
            {
            Console.WriteLine("Qual o nome do torcedor");
            nome = Console.ReadLine();

            Console.WriteLine("Para qual seleção você torce?");
            Console.WriteLine("Brasil = 1 / Argentina = 2 / Alemanha = 3 / Portugal = 4");
            seleção = int.Parse(Console.ReadLine());

            if (seleção = 1)
            {
                brasil++;
            }
            else if ( seleção = 2)
            {
                argentina++;
            }
            else if ( seleção = 3)
            {
                alemanha++;
            }
            else if (seleção = 4)
            {
                portugal++;
            }
            cont++;
            }
            porcentagem = cont / 100;
            pBrasil = porcentagem * brasil;
            pArgentina = porcentagem * argentina;
            pAlemanha = porcentagem * alemanha;
            pPortugal = porcentagem * portugal;

            Console.WriteLine("A seleção do Brasil tem " + brasil + " torcedores " + pBrasil + "%");
            Console.WriteLine("A seleção da Argentina tem " + argentina + " torcedores " + pArgentina + "%");
            Console.WriteLine("A seleção do Brasil tem " + argentina + " torcedores " + pAlemanha + "%");
            Console.WriteLine("A seleção do Brasil tem " + portugal + " torcedores " + pPortugal + "%");
        }
    }
}
